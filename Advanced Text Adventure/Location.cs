using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Console_RPG
{

    class Location
    {

        public static Location Location1 = new Location("Gradan Village", "Sunny", "The small village of Gradan. This is the home of " + Player.player1.name + ".", new AllEvents(new List<Event>() { new Shop("Ivan", new List<Item>() { HealingItem.Healing1, Weapon.Weapon1, Weapon.Weapon2, Armor.Armor1, Armor.Armor2 }), new Hotel(false, 15), new Gambling(false), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location2 = new Location("Kilun Plains", "Sunny", "The plains of the Kingdom of Kilun.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.enemy3, Enemy.enemy4 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location3 = new Location("Dargo Mountains", "Sunny", "Despite the high peaks, these mountains are never snowy.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.enemy1, Enemy.enemy2 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location4 = new Location("Kilun Castle Town", "Sunny", "The legendary Castle Town of Kilun Kingdom.", new AllEvents(new List<Event>() { new Shop("John", new List<Item>() { HealingItem.Healing1, Weapon.Weapon2, Weapon.Weapon3, Armor.Armor2, Armor.Armor3 }), new Hotel(false, 25), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location5 = new Location("Kilun Castle", "Sunny", "The impenetrable Kilun Castle.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.miniboss }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location6 = new Location("Dargo Castle Town", "Sunny", "The castle town of the mountain kingdom of Dargo.", new AllEvents(new List<Event>() { new Shop("Thomas", new List<Item>() { HealingItem.Healing1, ManaItem.Mana1, Weapon.Weapon3, Weapon.Weapon4, Armor.Armor3, Armor.Armor4 }), new Hotel(false, 40), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location23 = new Location("Dargo Castle", "Sunny", "The castle of the mountain kingdom of Dargo.", new AllEvents(new List<Event>() { new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location7 = new Location("Dargo Volcano", "Sunny", "The harsh volcano. A dragon is said to live here.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.miniboss2 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location8 = new Location("Reida Village", "Sunny", "A small village in Dargo. Home to " + Player.player2.name + ".", new AllEvents(new List<Event>() { new Shop("Wilson", new List<Item>() { HealingItem.Healing2, ManaItem.Mana1, Weapon.Weapon4, Weapon.Weapon5, Weapon.Weapon6, Armor.Armor4, Armor.Armor5 }), new Hotel(false, 50), new CheckInventory(Player.Inventory), new Recruit(Player.player2, "Hi! I heard you're going to fight the dark lord. I'm going to join you!"), new Leave() }));
        public static Location Location9 = new Location("Lonchester Plains", "Snowy", "The snowy plains of Lonchester. Many people have gotten lost in these plains.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.enemy5, Enemy.enemy6 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location10 = new Location("Lonchester Village", "Snowy", "The village of Lonchester. It's very warm and cozy.", new AllEvents(new List<Event>() { new Shop("Dalvin", new List<Item>() { HealingItem.Healing2, ManaItem.Mana2, Weapon.Weapon5, Weapon.Weapon7, Armor.Armor6, Armor.Armor7 }), new Hotel(false, 100), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location11 = new Location("Lonchester Royal Hall", "Sunny", "The royal hall of Lonchester. Where the nobles of Lonchester gather.", new AllEvents(new List<Event>() { new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location21 = new Location("Icy Tomb", "Snowy", "A tomb made of ice. A yeti is said to live there.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.miniboss3 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location12 = new Location("Aida Village", "Snowy", "A small village in Lonchester. Birthplace of " + Player.player3.name + ".", new AllEvents(new List<Event>() { new Shop("Charlotte", new List<Item>() { HealingItem.Healing3, ManaItem.Mana2, Weapon.Weapon5, Weapon.Weapon7, Armor.Armor6, Armor.Armor7 }), new Hotel(false, 120), new CheckInventory(Player.Inventory), new Recruit(Player.player3, "Hello. I heard you want to kill the dark lord. Take me with you."), new Leave() }));
        public static Location Location13 = new Location("Brago Jungle", "Rainy", "The rainy jungle of Brago. Teeming with plant life.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.enemy7, Enemy.enemy8, Enemy.enemy9 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location14 = new Location("Brago Tree", "Rainy", "This tree is a home to many native to Brago.", new AllEvents(new List<Event>() { new Shop("Thaddeus", new List<Item>() { HealingItem.Healing3, ManaItem.Mana3, Weapon.Weapon9, Weapon.Weapon10, Armor.Armor10, Armor.Armor9 }), new Hotel(false, 150), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location15 = new Location("Hall of Brago Chief", "Sunny", "The hall of the Chief of Brago.", new AllEvents(new List<Event>() { new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location22 = new Location("Death Ruins", "Rainy", "The Ruins of a Village of Brago, destroyed by the Dark Lord's army.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.miniboss4 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location16 = new Location("Gomba Village", "Rainy", "A village of the Jungle of Brago. Home of the Gombas.", new AllEvents(new List<Event>() { new Shop("Gomba II", new List<Item>() { HealingItem.Healing3, ManaItem.Mana3, Weapon.Weapon8, Weapon.Weapon9, Weapon.Weapon10, Armor.Armor8, Armor.Armor10 }), new Hotel(false, 150), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location17 = new Location("Dark Lord's Realm", "Ashen", "The plains of the former kingdom of Kehidupan. Taken over by the Dark Lord.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.enemy12, Enemy.enemy13 }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location Location18 = new Location("Surma Village", "Ashen", "A ghost town, though there may be some ghosts willing to help.", new AllEvents(new List<Event>() { new Shop("Barry III", new List<Item>() { HealingItem.Healing3, ManaItem.Mana3, Weapon.Weapon10, Weapon.Weapon11, Armor.Armor10, Armor.Armor11 }), new Hotel(false, 200), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location19 = new Location("Kematian Castle Town", "Ashen", "Formerly the Castle Town of Kehidupan. There are very few survivors in this town.", new AllEvents(new List<Event>() { new Shop("Deama", new List<Item>() { HealingItem.Healing3, ManaItem.Mana3, Weapon.Weapon11, Weapon.Weapon12, Armor.Armor11, Armor.Armor12 }), new Hotel(false, 250), new CheckInventory(Player.Inventory), new Leave() }));
        public static Location Location20 = new Location("Dark Lord's Castle", "Ashen", "The final castle of the dark lord.", new AllEvents(new List<Event>() { new Battle(new List<Enemy>() { Enemy.secondlastboss, Enemy.truefinalboss }, "Sunny"), new CheckInventory(Player.Inventory) }));
        public static Location SecretLocation = new Location("Dark Lord's Temple", "Sunny", "The secret temple of the dark lord. The legendary dark blade is said to reside here.", new AllEvents(new List<Event>() { new Shop("Guy", new List<Item>() { HealingItem.Healing3, ManaItem.Mana3, Weapon.SecretWeapon, Armor.SecretArmor }), new Hotel(false, 0), new CheckInventory(Player.Inventory), new Leave() }));

        public string name;
        public string weather;
        public string description;
        public AllEvents AllEvents;
        public Location North, East, South, West;

        public Location(string name, string weather, string description, AllEvents AllEvent = null)
        {
            this.name = name;
            this.weather = weather;
            this.description = description;
            this.AllEvents = AllEvent;
        }


        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {

            if (!(north is null))
            {
                this.North = north;
                north.South = this;
            }
            if (!(east is null))
            {
                this.East = east;
                east.West = this;
            }
            if (!(south is null))
            {
                this.South = south;
                south.North = this;
            }
            if (!(west is null))
            {
                this.West = west;
                west.East = this;
            }
        }

        public void Resolve(List<Player> players, List<Event> Events)
        {
            Program.LetterPrintingLine("You have arrived in " + this.name + ".", 40);
            Program.LetterPrintingLine(this.description, 20);
            AllEvents?.Resolve(players, Events);
            Console.WriteLine();
            Program.LetterPrintingLine("Where would you like to go?", 20);
            Console.WriteLine();

            if (!(this.North is null))
            {
                Program.LetterPrintingLine("North: " + this.North.name, 20);
            }
            if (!(this.East is null))
            {
                Program.LetterPrintingLine("East: " + this.East.name, 20);
            }
            if (!(this.South is null))
            {
                Program.LetterPrintingLine("South: " + this.South.name, 20);
            }
            if (!(this.West is null))
            {
                Program.LetterPrintingLine("West: " + this.West.name, 20);
            }

            string direction = Console.ReadLine().ToLower();
            Location nextLocation = null;

            while (true)
            {
                if (direction == "north")
                {
                    nextLocation = this.North;
                    break;
                }
                else if (direction == "east")
                {
                    nextLocation = this.East;
                    break;
                }
                else if (direction == "south")
                {
                    nextLocation = this.South;
                    break;
                }
                else if (direction == "west")
                {
                    nextLocation = this.West;
                    break;
                }
                else
                {

                }
            }

            Console.WriteLine();
            nextLocation.Resolve(players, nextLocation.AllEvents.Events);
        }
    }
}