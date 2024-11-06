using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Console_RPG
{
    class CheckInventory : Event
    {
        List<Item> Inventory;

        public CheckInventory(List<Item> inventory) : base(false)
        {
            this.Inventory = inventory;
        }

        public Player ChoosePlayerTarget(List<Player> choices)
        {
            Program.LetterPrintingLine("What target would you like to choose?", 20);
            for (int x = 0; x < choices.Count; x++)
            {
                Program.LetterPrintingLine($"{x + 1} {choices[x]}", 20);
            }
            int choiced = 0;
            try { choiced = Int32.Parse(Console.ReadLine()); }
            catch { Program.LetterPrintingLine("Invalid Target.", 20); }
            Console.WriteLine();
            return choices[choiced - 1];

        }
        public override void Resolve(List<Player> players)
        {
            while (true)
            {
                Program.LetterPrintingLine("What would you like to do?", 20);
                Program.LetterPrintingLine("EQUIP | USE | LEAVE", 20);
                string Choice = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (Choice == "equip")
                {
                    Program.LetterPrintingLine("What would you like to equip?", 20);
                    int j = 0;
                    for (int x = 0; x < Player.Inventory.Count; x++)
                    {
                        Program.LetterPrintingLine($"{x + 1} {Player.Inventory[x].name}", 20);
                        j = x;
                    }
                    j = Player.Inventory.Count + 2;
                    Program.LetterPrintingLine(j + " Leave", 20);
                    int choiced = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    int chosen = choiced - 1;

                    if (chosen == Inventory.Count)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        if (Inventory[chosen] is Weapon WeaponItem)
                        {
                            Player target = ChoosePlayerTarget(players.Cast<Player>().ToList());
                            WeaponItem.EquipWeapon(WeaponItem, target);
                        }
                        else if (Inventory[chosen] is Armor ArmorItem)
                        {
                            Player target = ChoosePlayerTarget(players.Cast<Player>().ToList());
                            ArmorItem.EquipArmor(ArmorItem, target);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Program.LetterPrintingLine("You cannot use this item.", 20);
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }



                }
                else if (Choice == "use")
                {
                    Program.LetterPrintingLine("What would you like to equip?", 20);
                    int j = 0;
                    for (int x = 0; x < Player.Inventory.Count; x++)
                    {
                        Program.LetterPrintingLine($"{x + 1} {Player.Inventory[x].name}", 20);
                        j = x;
                    }
                    Program.LetterPrintingLine((j + 1) + " Leave", 20);
                    int choiced = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    int chosen = choiced - 1;

                    if (Inventory[chosen] is HealingItem)
                    {
                        Player target = ChoosePlayerTarget(players.Cast<Player>().ToList());
                        Inventory[chosen].Use(Player.player1, target);
                    }
                    if (Inventory[chosen] is ManaItem)
                    {
                        Player target = ChoosePlayerTarget(players.Cast<Player>().ToList());
                        Inventory[chosen].Use(Player.player1, target);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.LetterPrintingLine("You cannot use this item.", 20);
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
                else if (Choice == "leave")
                {
                    Program.LetterPrintingLine("You left the inventory.", 20);
                    break;
                }
            }
        }
    }
}