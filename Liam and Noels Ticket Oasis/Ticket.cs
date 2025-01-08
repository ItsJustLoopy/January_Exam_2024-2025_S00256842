using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liam_and_Noels_Ticket_Oasis
{
    public class Ticket
    {
        // Properties
        public  string Name { get; set; }
        public  decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        // Constructors
        public Ticket() 
        { 
            Name = "Standard Ticket";
            Price = 0.00m;
            AvailableTickets = 0;
        }

        // Methods

        public override string ToString()
        {
            return $"{Name} - €{Price} [AVAILABLE - {AvailableTickets}]";
        }


        public class VIPTicket : Ticket
        {
            // Properties

            public string AdditionalExtras { get; set; }

            public decimal AdditionalCost { get; set; }


            // Constructors

            public VIPTicket()
            {
                Name = "VIP Ticket";
                Price = 0.00m;
                AdditionalExtras = "No extras";
                AdditionalCost = 0.00m;
                AvailableTickets = 0;
            }

            // Methods
            public override string ToString()
            {
                return $"{Name} - €{Price + AdditionalCost} ({AdditionalExtras}) [AVAILABLE - {AvailableTickets}]";
            }
        }
    }
    

    
}
