using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Linq;
using System.Numerics;

namespace Console_RPG
{
    class AllEvents
    {
        public List<Event> Events;
        public AllEvents(List<Event> Events)
        {
            this.Events = Events;
        }

        public void Resolve(List<Player> players, List<Event> Events)
        {
            while (true)
            {
                Program.LetterPrintingLine("Where would you like to go?", 20);
                for (int i = 0; i < Events.Count; i++)
                {
                    Program.LetterPrintingLine($"{i + 1} {Events[i]}", 20);
                }
                string input = Console.ReadLine();
                int eventchosen;
                if (int.TryParse(input, out eventchosen))
                {
                    Console.WriteLine();
                    int theevent = eventchosen - 1;

                    if (theevent == Events.Count - 1)
                    {
                        Events[theevent].Resolve(players);
                        break;
                    }
                    else if (theevent < Events.Count - 1)
                    {
                        Events[theevent].Resolve(players);
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
