using System;

namespace Console_RPG
{
    class ManaItem : Item
    {

        public static ManaItem Mana1 = new ManaItem("Mana Extract", "A bit of mana. Heals for 10 MP.", 60, 30, 0, 10);
        public static ManaItem Mana2 = new ManaItem("Mana Tree", "A small tree. Heals for 30 MP.", 100, 50, 0, 30);
        public static ManaItem Mana3 = new ManaItem("Magician's Tears", "Heals 50 MP.", 300, 150, 0, 50);

        public ManaItem(string name, string description, int buyPrice, int sellprice, int healAmount, int restoreAmount) : base(name, description, buyPrice, sellprice, healAmount, restoreAmount)
        {

        }
    }
}
