using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Liam_and_Noels_Ticket_Oasis
{
    public class Event : IComparable<Event>
    {
        // Properties

        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public EventType TypeOfEvent { get; set; }
        public List<Ticket> Tickets { get; set; }

        public enum EventType 
        {
            Music,
            Comedy,
            Theatre
        }

        //Constructors
        public Event()
        {
            
            Name = "Event";
            EventDate = DateTime.Now;
            EventType typeOfEvent = TypeOfEvent;
            Tickets = new List<Ticket>();
        }

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

        public override string ToString()
        {
            return $"{Name} - {EventDate}";
        }

    }
}
