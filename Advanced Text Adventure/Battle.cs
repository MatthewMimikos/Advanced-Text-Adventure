using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Console_RPG
{
    class Battle : Event
    {
        public List<Enemy> enemies;
        public string Weather;


        public Battle(List<Enemy> enemies, string weather) : base(false)
        {
            this.enemies = enemies;
            this.Weather = weather;
        }

        public override void Resolve(List<Player> players)
        {
            for (int x = 0; x < enemies.Count; x++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Program.LetterPrintingLine(enemies[x].name + " Attacked!", 30);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine();
            // Loop the turn system.
            while (true)
            {
                //Loop through all the players
                foreach (var player in players)
                {
                    if (Player.player1.currentHP > 0)
                    {
                        Program.LetterPrintingLine("PLAYER PHASE", 20);
                        for (int x = 0; x < players.Count; x++)
                        {
                            if (players[x].currentHP > 0)
                            {
                                Program.LetterPrintingLine(players[x].name + " has " + players[x].currentHP + " HP and " + players[x].currentMana + " MP.", 20);
                            }
                        }
                        player.DoTurn(players, enemies);
                        for (int x = 0; x < enemies.Count; x++)
                        {
                            if (enemies[x].currentHP < 0)
                            {
                                Program.LetterPrintingLine(enemies[x].name + " is dead!", 20);
                            }
                        }
                    }
                }
                foreach (var enemy in enemies)
                {
                    if (enemy.currentHP > 0)
                    {
                        Program.LetterPrintingLine("ENEMY PHASE", 20);
                        Console.WriteLine();
                        enemy.DoTurn(players, enemies);
                    }
                }

                if (enemies.TrueForAll(enemy => enemy.currentHP <= 0))
                {
                    int enemyGold = 0;
                    int enemyEXP = 0;
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemyGold += enemies[i].GoldDropped;
                    }
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemyEXP += enemies[i].EXP;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Program.LetterPrintingLine("You won! You got " + enemyGold + " gold, and earned " + enemyEXP + " EXP.", 40);
                    Console.ForegroundColor = ConsoleColor.Black;
                    for (int i = 0; i < players.Count; i++)
                    {
                        players[i].EXP += enemyEXP;

                    }
                    Player.GoldAmount += enemyGold;
                    break;
                }

                else if (players[0].currentHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.LetterPrintingLine("YOU DIED.", 100);
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }
                else
                {

                }
            }
        }
    }
}