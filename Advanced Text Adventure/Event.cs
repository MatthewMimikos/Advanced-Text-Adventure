using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace Console_RPG
{
    abstract internal class Event
    {
        public bool isResolved;

        public Event(bool isResolved)
        {
            this.isResolved = isResolved;
        }

        public abstract void Resolve(List<Player> players);
    }
}
