using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Player : Entity
    {
        public static List<Item> Inventory = new List<Item>()
        {
            HealingItem.Healing1
        };

        public static List<Player> PlayerList = new List<Player>() { Player.player1 };

        public static int GoldAmount = 100;
        public static Player player1 = new Player("Daniel", 12, 3, new Stats(5, 3, 4, 2, 0), Weapon.Weapon1, Armor.Armor1, 0, 1);
        public static Player player2 = new Player("Alice", 17, 0, new Stats(8, 5, 2, 0, 1), Weapon.Weapon3, Armor.Armor3, 0, 3);
        public static Player player3 = new Player("Jay", 10, 10, new Stats(3, 1, 6, 7, 5), Weapon.Weapon2, Armor.Armor2, 0, 5);

        public Weapon weapon;
        public Armor armor;
        public int EXP;
        public int Level;

        public Player(string name, int hp, int mana, Stats stats, Weapon weapon1, Armor armor1, int EXP, int Level) : base(name, hp, mana, stats)
        {
            this.EXP = EXP;
            this.weapon = weapon1;
            this.armor = armor1;
            this.EXP = EXP;
            this.Level = Level;
        }
        public Enemy ChooseTarget(List<Enemy> choices)
        {
            Program.LetterPrintingLine("What target would you like to choose?", 20);
            choices.OrderBy(e => e.name).ToList();
            for (int x = 0; x < choices.Count; x++)
            {
                Console.WriteLine($"{x + 1} {choices[x].name}");
            }
            int choiced = 0;
            try { choiced = Int32.Parse(Console.ReadLine()); }
            catch { Program.LetterPrintingLine("Invalid Target.", 20); }
            Console.WriteLine();
            return choices[choiced - 1];
        }
        public Player ChoosePlayerTarget(List<Player> choices)
        {
            Console.WriteLine("What target would you like to choose?");
            for (int x = 0; x < choices.Count; x++)
            {
                Console.WriteLine($"{x + 1} {choices[x]}");
            }
            int choiced = 0;
            try { choiced = Int32.Parse(Console.ReadLine()); }
            catch { Program.LetterPrintingLine("Invalid Target.", 20); }
            Console.WriteLine();
            return choices[choiced - 1];
        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("What item would you like to choose?");
            for (int x = 0; x < choices.Count; x++)
            {
                Console.WriteLine($"{x + 1} {choices[x].name}");
            }
            int choiced = 0;
            try { choiced = Int32.Parse(Console.ReadLine()); }
            catch { Program.LetterPrintingLine("Invalid Target.", 20); }
            Console.WriteLine();
            return choices[choiced - 1];
        }
        public void Attack(Enemy target)
        {
            var x = new Random();
            var p = x.Next(100);
            if (p >= 100 - this.weapon.accuracy)
            {
                target.currentHP = target.currentHP - (this.stats.strength + this.weapon.attack) - target.stats.defense;
                Program.LetterPrintingLine(this.name + " has attacked " + target.name + ". It did " + ((this.stats.strength + this.weapon.attack) - target.stats.defense) + " damage.", 20);
            }
            else
            {
                Program.LetterPrintingLine(this.name + " has missed!", 20);
            }
        }

        public void MagicAttack(Enemy target)
        {
            var x = new Random();
            var p = x.Next(100);
            if (p >= 100 - this.weapon.accuracy)
            {
                int magicdamage = this.stats.magic - target.stats.resistance;
                target.currentHP = target.currentHP - magicdamage;
                this.currentMana = this.currentMana - 2;
                Program.LetterPrintingLine(this.name + " has used magic to attack " + target.name + ". It did " + magicdamage + " damage.", 20);
            }
            else
            {
                Program.LetterPrintingLine(this.name + " has missed!", 20);
            }
        }
        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Program.LetterPrintingLine("What do you want to do?", 20);
            Program.LetterPrintingLine("Attack | Magic | Item", 20);
            string choice = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (choice == "attack")
            {
                Enemy target = ChooseTarget(enemies.Cast<Enemy>().ToList());
                Attack(target);
            }
            if (choice == "magic")
            {
                Enemy target = ChooseTarget(enemies.Cast<Enemy>().ToList());
                Attack(target);
            }
            else if (choice == "item")
            {
                Item item = ChooseItem(Inventory);
                Player target = ChoosePlayerTarget(enemies.Cast<Player>().ToList());

                item.Use(this, target);
                Inventory.Remove(item);
            }
            else
            {
                Program.LetterPrintingLine("Invalid Response.", 20);
            }
        }

        public void LevelUp(Player player)
        {
            int levelupnumber = 100;
            if (player.EXP == levelupnumber)
            {
                player.Level += 1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Program.LetterPrintingLine(player.name + " has leveled up!", 20);
                Program.LetterPrintingLine(player.name + " is now level " + player.Level + ".", 20);
                player.stats.strength += 2;
                player.stats.defense += 2;
                player.stats.magic += 1;
                player.stats.resistance += 1;
                player.stats.speed += 2;
                Program.LetterPrintingLine(player.name + "'s strength has increased to " + player.stats.strength + "!", 20);
                Program.LetterPrintingLine(player.name + "'s defense has increased to " + player.stats.defense + "!", 20);
                Program.LetterPrintingLine(player.name + "'s magic has increased to " + player.stats.magic + "!", 20);
                Program.LetterPrintingLine(player.name + "'s resistance has increased to " + player.stats.strength + "!", 20);
                Program.LetterPrintingLine(player.name + "'s speed has increased to " + player.stats.strength + "!", 20);
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}