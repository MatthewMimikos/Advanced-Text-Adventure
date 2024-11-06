using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Console_RPG
{
    class Enemy : Entity
    {

        public static Enemy enemy1 = new Enemy("Goblin", 15, 0, new Stats(5, 4, 3, 0, 0), 3, 5, 85);
        public static Enemy enemy14 = new Enemy("Derek", 5, 0, new Stats(5, 0, 2, 0, 6), 3, 5, 40);
        public static Enemy enemy2 = new Enemy("Bandit", 21, 0, new Stats(8, 4, 5, 0, 3), 6, 20, 75);
        public static Enemy enemy10 = new Enemy("Gargoyle", 24, 0, new Stats(7, 4, 6, 0, 3), 6, 20, 75);
        public static Enemy enemy3 = new Enemy("Magician", 22, 20, new Stats(4, 3, 4, 8, 12), 10, 15, 72);
        public static Enemy enemy4 = new Enemy("Orc", 34, 1, new Stats(10, 7, 5, 4, 5), 12, 20, 59);
        public static Enemy enemy5 = new Enemy("Giant", 30, 0, new Stats(15, 6, 3, 0, 5), 16, 24, 50);
        public static Enemy enemy6 = new Enemy("Soldier", 36, 0, new Stats(7, 10, 4, 0, 0), 22, 40, 80);
        public static Enemy enemy7 = new Enemy("Deadly Plant", 40, 0, new Stats(11, 4, 6, 0, 0), 25, 50, 75);
        public static Enemy enemy8 = new Enemy("Ninja", 63, 15, new Stats(12, 6, 9, 10, 5), 45, 60, 95);
        public static Enemy enemy12 = new Enemy("Zombie", 88, 0, new Stats(15, 5, 4, 0, 5), 60, 100, 70);
        public static Enemy enemy13 = new Enemy("Dark Royal Guard", 122, 0, new Stats(17, 12, 10, 0, 7), 45, 60, 95);
        public static Enemy enemy9 = new Enemy("Gomba", 1, 0, new Stats(999, 0, 10, 0, 0), 30, 200, 10);

        public static Enemy miniboss = new Enemy("General", 150, 0, new Stats(24, 12, 11, 0, 0), 100, 150, 80);
        public static Enemy miniboss2 = new Enemy("Fire Dragon", 200, 0, new Stats(27, 11, 11, 0, 24), 100, 150, 80);
        public static Enemy miniboss3 = new Enemy("Yeti", 300, 0, new Stats(30, 16, 14, 0, 12), 100, 150, 80);
        public static Enemy miniboss4 = new Enemy("Demon", 400, 0, new Stats(20, 22, 13, 30, 22), 100, 150, 80);
        public static Enemy secondlastboss = new Enemy("Blade Lord", 500, 0, new Stats(38, 26, 20, 0, 20), 0, 0, 90);
        public static Enemy truefinalboss = new Enemy("Dark Lord", 800, 0, new Stats(50, 30, 24, 0, 40), 0, 0, 90);

        public int EXP;
        public int GoldDropped;
        public int Accuracy;



        public Enemy(string name, int hp, int mana, Stats stats, int EXP, int GoldDropped, int accuracy) : base(name, hp, mana, stats)
        {
            this.EXP = EXP;
            this.GoldDropped = GoldDropped;
            this.Accuracy = accuracy;
        }


        public Player ChooseTarget(List<Player> choices)
        {
            Random random = new Random();
            return choices[random.Next(choices.Count)];
        }
        public void Attack(Player target)
        {
            var x = new Random();
            var p = x.Next(100);
            if (p >= 100 - Accuracy)
            {
                int enemydamage = stats.strength - (target.stats.defense + target.armor.defense);
                Console.WriteLine(this.name + " has attacked " + target.name + ". It did " + enemydamage + " damage!");
                target.currentHP -= enemydamage;
            }
            else
            {
                Console.WriteLine(this.name + " has missed!");
            }
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            enemies.OrderBy(e => e.name).ToList();
            Player target = ChooseTarget(players.Cast<Player>().ToList());
            Attack(target);
        }

        public void Artelius()
        {
            Console.WriteLine("I dunno what to put here.");
        }
    }
}