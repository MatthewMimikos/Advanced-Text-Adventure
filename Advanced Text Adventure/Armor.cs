using System;
using System.Numerics;
using System.Xml.Linq;

namespace Console_RPG
{
    class Armor : Equipment
    {
        public static Armor Armor0 = new Armor("Unequipped", "Currently you don't have anything equipped.", 0, 0, 0, 0, 0);
        public static Armor Armor1 = new Armor("Cloth", "A piece of cloth. Offers little defense.", 40, 20, 1, 0, 0);
        public static Armor Armor2 = new Armor("Leather Armor", "Armor made of leather. Somewhat useful for adventurers", 80, 40, 3, 0, 0);
        public static Armor Armor3 = new Armor("Iron Armor", "Armor made of iron. Used commonly by knights. A little stiff.", 140, 70, 5, 0, 0);
        public static Armor Armor4 = new Armor("Dargo Royal Guard Armor", "Armor gifted to you by the king of Dargo. Pretty strong.", 0, 250, 7, 0, 0);
        public static Armor Armor5 = new Armor("Flame Armor", "Strong Armor created in the volcano. Hot to the touch.", 0, 250, 8, 0, 0);
        public static Armor Armor6 = new Armor("Ice Armor", "A powerful kind of armor made of ice. Surprisingly, it cannot be broken.", 600, 300, 9, 0, 0);
        public static Armor Armor7 = new Armor("Titanium Armor", "Powerful Armor made of titanium. The strongest armor made of traditional materials.", 800, 400, 11, 0, 0);
        public static Armor Armor8 = new Armor("Gomba Costume", "A costume that makes you look like a Gomba. Studies say it makes you so pathetic that enemies won't attack you.", 900, 450, 12, 0, 0);
        public static Armor Armor9 = new Armor("Kitsune Armor", "Armor that was made by a Kitsune.", 1200, 600, 13, 0, 0);
        public static Armor Armor10 = new Armor("Electric Armor", "Powerful armor that was struck by lightning.", 1400, 700, 14, 0, 0);
        public static Armor Armor11 = new Armor("Death Armor", "Armor made by the dark lord's army.", 1800, 900, 16, 0, 0);
        public static Armor Armor12 = new Armor("Dark Armor", "The most powerful kind of armor.", 3000, 1500, 18, 0, 0);
        public static Armor SecretArmor = new Armor("Blessed Armor", "Legendary armor in the dark lord's temple. Only wieldable by those with pure hearts.", 0, 0, 25, 0, 0);

        public int defense;
        public Armor(string name, string description, int buyPrice, int sellprice, int defense, int healAmount, int restoreAmount) : base(name, description, buyPrice, sellprice, healAmount, restoreAmount)
        {
            this.defense = defense;
        }

        public void EquipArmor(Armor Armor, Player user)
        {
            if (!this.isEquipped)
            {
                user.armor = Armor;
                Console.WriteLine(name + " has been equipped.");
            }
            else if (this.isEquipped)
            {
                user.armor = Armor0;
                Console.WriteLine(name + " has been unequipped.");
            }

            this.isEquipped = !this.isEquipped;
        }
    }
}
