using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Shop : Event
    {
        public string shopKeeperName;
        public List<Item> items;

        public Shop(string shopKeeperName, List<Item> items) : base(false)
        {
            this.shopKeeperName = shopKeeperName;
            this.items = items;
        }

        public override void Resolve(List<Player> players)
        {
            while (true)
            {
                Program.LetterPrintingLine("Welcome to the shop. What would you like?", 20);
                Program.LetterPrintingLine("BUY | SELL | LEAVE", 20);
                string userChoice = Console.ReadLine().ToLower();
                if (userChoice == "buy")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Program.LetterPrintingLine("You currently have " + Player.GoldAmount + " Gold.", 20);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Item item = ChooseItem(items);
                    if (Player.GoldAmount > item.buyPrice)
                    {
                        Player.Inventory.Add(item);
                        Program.LetterPrintingLine("You bought " + item.name + ".", 20);
                        Player.GoldAmount -= item.buyPrice;
                    }
                    else if (Player.GoldAmount < item.buyPrice)
                    {
                        Program.LetterPrintingLine("You don't have enough gold. You cannot buy the item.", 20);
                    }
                }
                else if (userChoice == "sell")
                {
                    Console.WriteLine();
                    Item item = ChooseSellItem(Player.Inventory);
                    if (Player.GoldAmount > item.buyPrice)
                    {
                        Player.Inventory.Remove(item);
                        Program.LetterPrintingLine("You sold " + item.name + ". You got " + item.sellprice + " gold.", 20);
                        Player.GoldAmount += item.buyPrice;
                    }
                }
                else if (userChoice == "leave")
                {
                    Console.WriteLine();
                    Program.LetterPrintingLine("You left the shop.", 20);
                    break;
                }
            }

        }

        public Item ChooseItem(List<Item> choices)
        {
            for (int x = 0; x < choices.Count; x++)
            {
                Program.LetterPrintingLine($"{x + 1} {choices[x].name} ({choices[x].buyPrice} GOLD)", 10);
            }
            int choiced = 0;
            try { choiced = Int32.Parse(Console.ReadLine()); }
            catch { Program.LetterPrintingLine("Invalid Target.", 20); }
            Console.WriteLine();
            return choices[choiced - 1];
        }
        public Item ChooseSellItem(List<Item> choices)
        {
            for (int x = 0; x < choices.Count; x++)
            {
                Program.LetterPrintingLine($"{x + 1} {choices[x].name} ({choices[x].sellprice} GOLD)", 10);
            }
            int choiced = 0;
            try { choiced = Int32.Parse(Console.ReadLine()); }
            catch { Program.LetterPrintingLine("Invalid Target.", 20); }
            Console.WriteLine();
            return choices[choiced - 1];
        }
    }
}
