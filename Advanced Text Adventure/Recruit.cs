using System.Collections.Generic;

namespace Console_RPG
{
    class Recruit : Event
    {
        public Player Recruiting;
        public string RecruitDialogue;

        public Recruit(Player recruiting, string recruitDialogue) : base(false)
        {
            Recruiting = recruiting;
            RecruitDialogue = recruitDialogue;
        }

        public override void Resolve(List<Player> players)
        {
            Program.LetterPrintingLine("You walk up to " + Recruiting.name + ".", 20);
            Program.LetterPrintingLine(Recruiting.name + ": " + RecruitDialogue, 20);
            players.Add(Recruiting);
            Program.LetterPrintingLine("You have now recruited " + Recruiting.name + "!", 20);
        }
    }

}
