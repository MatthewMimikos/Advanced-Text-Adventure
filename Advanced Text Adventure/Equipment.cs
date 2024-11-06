using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Equipment : Item
    {
        public bool isEquipped;

        public Equipment(string name, string description, int buyPrice, int sellprice, int healAmount, int restoreAmount) : base(name, description, buyPrice, sellprice, healAmount, restoreAmount)
        {
            isEquipped = false;
        }
    }
}
