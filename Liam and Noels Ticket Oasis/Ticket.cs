using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liam_and_Noels_Ticket_Oasis
{
    internal class Ticket
    {
        // Properties
        public  string Name { get; set; }
        public  decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        // Constructors

        // Methods


        internal class VIPTicket : Ticket
        {
            // Properties

            public string AdditionalExtras { get; set; }

            public decimal AdditionalCost { get; set; }


            // Constructors

            // Methods
        }
    }
    

    
}
