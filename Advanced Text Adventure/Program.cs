using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Threading;

namespace Console_RPG
{
    class Program
    {
        public static void LetterPrinting(string words, int time)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
                Thread.Sleep(time);
            }
        }

        public static void LetterPrintingLine(string words, int time)
        {
            LetterPrinting(words, time);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Location.Location1.SetNearbyLocations(north: Location.Location2, south: Location.Location9);
            Location.Location2.SetNearbyLocations(north: Location.Location4, west: Location.Location3, east: Location.Location13, south: Location.Location1);
            Location.Location3.SetNearbyLocations(north: Location.Location7, west: Location.Location6, east: Location.Location2, south: Location.Location8);
            Location.Location4.SetNearbyLocations(north: Location.Location5, south: Location.Location2);
            Location.Location5.SetNearbyLocations(south: Location.Location4);
            Location.Location6.SetNearbyLocations(west: Location.Location23, east: Location.Location3);
            Location.Location23.SetNearbyLocations(east: Location.Location23);
            Location.Location7.SetNearbyLocations(south: Location.Location3);
            Location.Location8.SetNearbyLocations(north: Location.Location3);
            Location.Location9.SetNearbyLocations(north: Location.Location1, east: Location.Location21, west: Location.Location10, south: Location.Location12);
            Location.Location10.SetNearbyLocations(east: Location.Location9, south: Location.Location11);
            Location.Location11.SetNearbyLocations(north: Location.Location10);
            Location.Location21.SetNearbyLocations(west: Location.Location9);
            Location.Location12.SetNearbyLocations(north: Location.Location9);
            Location.Location13.SetNearbyLocations(west: Location.Location2, east: Location.Location14, north: Location.Location22, south: Location.Location16);
            Location.Location14.SetNearbyLocations(west: Location.Location13, north: Location.Location15);
            Location.Location15.SetNearbyLocations(south: Location.Location14);
            Location.Location22.SetNearbyLocations(south: Location.Location13, east: Location.Location17);
            Location.Location16.SetNearbyLocations(north: Location.Location13);
            Location.Location17.SetNearbyLocations(west: Location.Location22, south: Location.Location18, north: Location.Location19);
            Location.Location18.SetNearbyLocations(north: Location.Location17, east: Location.SecretLocation);
            Location.Location19.SetNearbyLocations(south: Location.Location17, north: Location.Location20);
            Location.Location20.SetNearbyLocations(south: Location.Location19);
            Location.SecretLocation.SetNearbyLocations(west: Location.SecretLocation);

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Location.Location1.Resolve(new List<Player> { Player.player1 }, Location.Location1.AllEvents.Events);

        }
    }
}