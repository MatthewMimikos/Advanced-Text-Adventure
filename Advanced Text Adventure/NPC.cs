using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Console_RPG
{
    class NPC : Entity
    {

        public int betrayal;
        public int EXP;
        public int Level;
        public Weapon weapon;
        public Armor armor;

        public NPC(string name, int hp, int mana, Stats stats, int betrayal, int exp, int Level, Weapon weapon1, Armor armor1) : base(name, hp, mana, stats)
        {
            this.betrayal = betrayal;
            this.EXP = exp;
            this.Level = Level;
            this.weapon = weapon1;
            this.armor = armor1;
        }
        public Enemy ChooseTarget(List<Enemy> choices)
        {
            Random random = new Random();
            return choices[random.Next(choices.Count)];
        }
        public void Attack(Enemy target)
        {
            var x = new Random();
            var p = x.Next(100);
            if (p >= 100 - this.weapon.accuracy)
            {
                target.currentHP = target.currentHP - (this.stats.strength + this.weapon.attack) - target.stats.defense;
                Console.WriteLine(this.name + " has attacked " + target.name + ". It did " + ((this.stats.strength + this.weapon.attack) - target.stats.defense) + " damage.");
            }
            else
            {
                Console.WriteLine(this.name + " has missed!");
            }
        }
        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Enemy target = ChooseTarget(players.Cast<Enemy>().ToList());
            Attack(target);
        }
    }
}