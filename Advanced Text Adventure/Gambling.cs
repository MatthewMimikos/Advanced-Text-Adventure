using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Console_RPG
{
    struct Vector2<height>
    {
        public height feet;
        public height inches;
    }
    struct Larry
    {
        public string larry;
        public string jerry;

        public Larry(string larry, string jerry)
        {
            this.larry = larry;
            this.jerry = jerry;
        }
    }
    class People
    {
        private string Mood;
        private int Age;

        public string ownerMood
        {
            get { return Mood; }
            set { Mood = value; }
        }
        public int ownerAge
        {
            get { return Age; }
            set { Age = value; }
        }
    }

    class Gambling : Event
    {
        public delegate void OwnmanName(string name);
        public static void DelegateMethod(string name)
        {
            Program.LetterPrintingLine(name, 20);
        }
        public Gambling(bool isResolved) : base(isResolved)
        {
            isResolved = false;
        }
        static void PrintIfNotNull(Nullable<Larry> barry)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            string serialLarry = JsonSerializer.Serialize(barry.Value.larry);
            if (barry.HasValue)
            {
                Program.LetterPrintingLine(barry.Value.jerry, 20);
                using StreamWriter Writer = new StreamWriter("biglarry.json");
                Writer.Write(serialLarry);
                Writer.Flush();
            }
            else
            {
                Program.LetterPrintingLine("Jerry died 10 years ago...", 20);
                JsonSerializer.Deserialize(barry.Value.larry, typeof(Larry));
            }
        }
        public override void Resolve(List<Player> players)
        {
            while (true)
            {
                Program.LetterPrintingLine("Welcome to the casino. What would you like to do?", 20);
                Program.LetterPrintingLine("GAMBLE | OWNER | LEAVE", 20);
                string userChoice = Console.ReadLine().ToLower();
                if (userChoice == "gamble")
                {
                    Console.WriteLine("");
                    Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold. How much would you like to bet?", 20);
                    string input = Console.ReadLine();
                    int goldGambled = 0;
                    int.TryParse(input, out goldGambled);
                    if (goldGambled < 0)
                    {
                        Program.LetterPrintingLine("You can't bet negative amounts of gold!", 20);
                        break;
                    }
                    if (goldGambled <= Player.GoldAmount || goldGambled > 0)
                    {
                        Player.GoldAmount -= goldGambled;
                        Console.WriteLine("");
                        Program.LetterPrintingLine("Time to gamble. Good Luck!", 20);
                        Program.LetterPrintingLine("GAMBLING...", 100);
                        var x = new Random();
                        var p = x.Next(1000);
                        if (p >= 0 && p < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Program.LetterPrintingLine("Critical Loss! You lose all of your gold!", 100);
                            Player.GoldAmount = 0;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold... Ouch!", 20);
                        }
                        if (p >= 1 && p < 400)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Program.LetterPrintingLine("You Lost! Too bad!", 50);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold.", 20);
                        }
                        if (p >= 400 && p < 500)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("Small Loss! You keep your gold.", 20);
                            Player.GoldAmount += goldGambled;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold.", 20);
                        }
                        if (p >= 500 && p < 800)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("Small Win! You gain 1.5x gold!", 20);
                            goldGambled = (int)(goldGambled * 1.5);
                            Player.GoldAmount += goldGambled;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold.", 20);
                        }
                        if (p >= 800 && p < 950)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Program.LetterPrintingLine("Medium Win! You gain 2x gold!", 50);
                            goldGambled = (int)(goldGambled * 2);
                            Player.GoldAmount += goldGambled;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold.", 20);
                        }
                        if (p >= 950 && p < 999)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Program.LetterPrintingLine("Epic Win! You gain 3x gold!", 100);
                            goldGambled = (int)(goldGambled * 3);
                            Player.GoldAmount += goldGambled;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + " Gold.", 20);
                        }
                        if (p >= 999 && p <= 1000)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Program.LetterPrintingLine("JACKPOT!!!", 500);
                            Program.LetterPrintingLine("Insane Win! You gain 100x gold!", 100);
                            goldGambled = (int)(goldGambled * 100);
                            Player.GoldAmount += goldGambled;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Program.LetterPrintingLine("You have " + Player.GoldAmount + "Gold! Wow!", 20);
                        }

                    }
                    else if (goldGambled > Player.GoldAmount)
                    {
                        Program.LetterPrintingLine("You don't have that much gold.", 20);
                        break;
                    }
                }
                else if (userChoice == "owner")
                {
                    Console.WriteLine();
                    People own = new People();
                    Program.LetterPrintingLine("Which of the owners do you want to learn about? 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13", 20);
                    string input = Console.ReadLine();
                    int whichderek = 0;
                    int.TryParse(input, out whichderek);
                    Program.LetterPrintingLine("This is the owner.", 20);
                    if (whichderek == 1)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Very Sad, all the time. Too busy running the casino, not enough time to gamble.";
                        own.ownerAge = 45;
                        handler("Name: Derek Jr.");
                        Nullable<Larry> jerry = null;
                        PrintIfNotNull(jerry);
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 5, inches = 0 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 2)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Happier than his father.";
                        own.ownerAge = 20;
                        handler("Name: Derek III");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 4, inches = 2 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 3)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Not a knight, but has a sword and shield.";
                        own.ownerAge = 143;
                        handler("Name: Sir Deryth");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 7, inches = 8 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 4)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Where banana?";
                        own.ownerAge = 42;
                        handler("Name: Derek Kong Jr.");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 12, inches = 4 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 5)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Nicknamed \"Darrel the Barrel\". Often gets thrown by Derek Kong Jr.";
                        own.ownerAge = 43;
                        handler("Name: Darrel");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 2, inches = 11 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 6)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "The first half. If you're bad at math. Which De is. Rek holds all the math knowledge.";
                        own.ownerAge = 54;
                        handler("Name: De");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 2, inches = 5 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 7)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Fuun fac: to plus to ekwals 4. Rek bad at speling. De hold spell noledj";
                        own.ownerAge = 54;
                        handler("Name: Rek");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 2, inches = 6 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 8)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Rich. Probably owns half of the world's oil. And lives off his father's money.";
                        own.ownerAge = 20;
                        handler("Name: Winston Derekson XVIX");
                        Nullable<Larry> jerry = new Larry("Jerry is real.", "Jerry is false.");
                        PrintIfNotNull(jerry);
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 5, inches = 1 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 9)
                    {
                        OwnmanName handler = DelegateMethod;

                        handler("Name: Derrick");
                        own.ownerMood = "Derek, but cool way. Like Derrick Hall. or Derrick from Lego Pirates of the Caribbean.";
                        own.ownerAge = 25;
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 6, inches = 5 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 10)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "Is this the real Derek? The one who started it all? Derek Derekson?";
                        own.ownerAge = 82;
                        handler("Name: The Real Derek?");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 5, inches = 4 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 11)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "It's a faker! He's not a real Derek!";
                        own.ownerAge = 64;
                        handler("Name: The Fake Derek!");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 5, inches = 7 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);

                    }
                    if (whichderek == 12)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "This Derek became evil. He tripped an old lady once.";
                        own.ownerAge = 35;
                        handler("Name: Evil Derek");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 4, inches = 5 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    if (whichderek == 13)
                    {
                        OwnmanName handler = DelegateMethod;
                        own.ownerMood = "It's a pet brick adopted into the Cinematic Universe.";
                        own.ownerAge = 95;
                        handler("Name: DeBrek");
                        Vector2<int> DJHeight = new Vector2<int>() { feet = 1, inches = 2 };
                        Program.LetterPrintingLine("Height: " + DJHeight.feet + " ft, " + DJHeight.inches + " inches.", 20);
                    }
                    Program.LetterPrintingLine("Description: " + own.ownerMood, 20);
                    Program.LetterPrintingLine("Age: " + own.ownerAge, 20);
                    Program.LetterPrintingLine("His family owns every casino in the world.", 20);
                }
                else if (userChoice == "leave")
                {
                    Console.WriteLine();
                    Program.LetterPrintingLine("You left the casino.", 20);
                    break;
                }
            }
        }
    }
}
