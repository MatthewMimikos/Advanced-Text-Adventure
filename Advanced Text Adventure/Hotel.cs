using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Console_RPG
{
    internal class Hotel : Event
    {
        public int Cost;

        public Hotel(bool isResolved, int Cost) : base(isResolved)
        {
            isResolved = false;
            this.Cost = Cost;
        }

        public override void Resolve(List<Player> players)
        {
            while (true)
            {
                Program.LetterPrintingLine("Welcome to the hotel! Would you like to stay here for one night? It's only " + Cost + " Gold!", 20);
                Program.LetterPrintingLine("SLEEP | LEAVE", 20);
                Program.LetterPrintingLine("You currently have " + Player.GoldAmount + " Gold.", 20);
                string userChoice = Console.ReadLine().ToLower();
                if (userChoice == "sleep")
                {
                    Console.WriteLine();
                    Program.LetterPrintingLine("Have a good night!", 20);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Program.LetterPrintingLine("ZZZ...", 100);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    for (int i = 0; i < players.Count; i++)
                    {
                        players[i].currentHP = players[i].maxHP;
                        players[i].currentMana = players[i].maxMana;
                        Program.LetterPrintingLine(players[i].name + "'s health is now full! They have " + players[i].currentHP + " HP!", 20);
                    }
                }
                else if (userChoice == "leave")
                {
                    Console.WriteLine();
                    Program.LetterPrintingLine("You left the hotel.", 20);
                    break;
                }
            }
        }
    }
}
