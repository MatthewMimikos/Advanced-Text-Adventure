using System;

namespace Console_RPG
{
    class Weapon : Equipment
    {

        public static Weapon Weapon1 = new Weapon("Dagger", "A common dagger. Nothing special.", 50, 25, 3, 95, 0, 0);
        public static Weapon Weapon2 = new Weapon("Log", "A really big stick.", 75, 37, 5, 80, 0, 0);
        public static Weapon Weapon3 = new Weapon("Broadsword", "A common sword of decent power.", 100, 50, 6, 85, 0, 0);
        public static Weapon Weapon4 = new Weapon("Iron Axe", "A solid axe. Very strong but innacurate.", 150, 75, 8, 75, 0, 0);
        public static Weapon Weapon5 = new Weapon("Falchion", "A curved and powerful sword.", 200, 100, 9, 85, 0, 0);
        public static Weapon Weapon6 = new Weapon("Wind Blade", "A blade powered by the winds of Dargo.", 400, 200, 11, 95, 0, 0);
        public static Weapon Weapon7 = new Weapon("Ice Bow", "A bow that shoots arrows made of ice.", 800, 400, 14, 86, 0, 0);
        public static Weapon Weapon8 = new Weapon("Gomba Gun", "A gun that is commonly used by Gombas.", 1200, 600, 50, 5, 0, 0);
        public static Weapon Weapon9 = new Weapon("Platinum Sword", "A powerful sword made of platinum.", 1600, 800, 17, 92, 0, 0);
        public static Weapon Weapon10 = new Weapon("Drago Royal Sword", "A stolen sword of the Drago Royal Family", 2000, 1000, 19, 94, 0, 0);
        public static Weapon Weapon11 = new Weapon("Grim Reaper's Scythe", "A scythe.", 1600, 800, 20, 92, 0, 0);
        public static Weapon Weapon12 = new Weapon("Dark Axe", "An axe, sometimes wielded by the dark lord.", 3000, 1500, 26, 96, 0, 0);
        public static Weapon SecretWeapon = new Weapon("Blessed Blade", "A secret blade, created for a hero.", 0, 0, 70, 100, 0, 0);

        public int attack;
        public int accuracy;
        public Weapon(string name, string description, int buyPrice, int sellprice, int Attack, int Accuracy, int healAmount, int restoreAmount) : base(name, description, buyPrice, sellprice, healAmount, restoreAmount)
        {
            this.attack = Attack;
            this.accuracy = Accuracy;
        }
        public void EquipWeapon(Weapon Weapon, Player user)
        {
            user.weapon = Weapon;
            Console.WriteLine(name + " has been equipped.");
        }
    }
}
