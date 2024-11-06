using System;

namespace Console_RPG
{
    class HealingItem : Item
    {

        public static HealingItem Healing1 = new HealingItem("Herb", "An herb. It can heal you for 10 HP.", 30, 15, 10, 0);
        public static HealingItem Healing2 = new HealingItem("Health Potion", "A health potion. Can heal 30 HP.", 50, 25, 30, 0);
        public static HealingItem Healing3 = new HealingItem("Strange Juice", "It's probably nothing bad. Heals 50 HP.", 150, 75, 50, 0);

        public HealingItem(string name, string description, int buyPrice, int sellprice, int healAmount, int restoreAmount) : base(name, description, buyPrice, sellprice, healAmount, restoreAmount)
        {

        }
    }
}
