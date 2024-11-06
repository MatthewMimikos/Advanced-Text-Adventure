using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Console_RPG
{
    abstract class Entity
    {
        public string name;

        public int currentHP, maxHP;
        public int currentMana, maxMana;
        public Stats stats;

        public Entity(string name, int hp, int mana, Stats stats)
        {
            this.name = name;
            this.currentHP = hp;
            this.maxHP = hp;
            this.currentMana = mana;
            this.maxMana = mana;
            this.stats = stats;
        }

        public abstract void DoTurn(List<Player> players, List<Enemy> enemies);
    }
}