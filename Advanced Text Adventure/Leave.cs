using System.Collections.Generic;
using System.Numerics;

namespace Console_RPG
{
    class Leave : Event
    {

        public Leave() : base(false)
        {
        }

        public override void Resolve(List<Player> players)
        {
            Program.LetterPrintingLine("You left.", 20);
        }
    }
}
