using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liam_and_Noels_Ticket_Oasis
{
    internal class Event : IComparable<Event>
    {
        // Properties

        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }

        public enum EventType
        {
            Music,
            Comedy,
            Theatre
        }

        //Constructors

        //Methods

        public int CompareTo(Event other)
        {
            if (other.EventDate > this.EventDate)
            {
                return -1;
            }
            else if (other.EventDate < this.EventDate)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
