using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {
        public string name;
        public string description;
        public int buyPrice;
        public int sellprice;
        public int healAmount;
        public int restoreAmount;

        public Item(string name, string description, int buyPrice, int sellprice, int healAmount, int restoreAmount)
        {
            this.name = name;
            this.description = description;
            this.buyPrice = buyPrice;
            this.sellprice = sellprice;
            this.healAmount = healAmount;
            this.restoreAmount = restoreAmount;
        }

        public void Use(Player user, Player target)
        {
            target.currentHP += this.healAmount;
            target.currentMana += this.restoreAmount;
            Console.WriteLine(target.name + "has healed by " + healAmount + " HP. and " + restoreAmount + " MP.");
            Console.WriteLine(target.name + "'s HP is now " + target.currentHP + " and their MP is " + target.currentMana + ".");
        }
    }
}
