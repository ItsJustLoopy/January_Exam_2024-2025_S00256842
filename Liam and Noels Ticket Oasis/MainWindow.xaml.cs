using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Liam_and_Noels_Ticket_Oasis
{
    // github repository link: https://github.com/ItsJustLoopy/January_Exam_2024-2025_S00256842 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Event> CreateEvent()
        {
            // Creates 2 events and adds one ticket and one VIPticket to each event
            Event OasisCrokePark = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = Event.EventType.Music };
            Event ElectricPicnic = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = Event.EventType.Music };

            Ticket OasisCrokeParkStandardTicket = new Ticket() { Name = "Early Bird", Price = 100.00m, AvailableTickets = 100 };
            OasisCrokePark.Tickets.Add(OasisCrokeParkStandardTicket);

            Ticket OasisCrokeParkVIPTicket = new Ticket.VIPTicket() { Name = "Ticket and Hotel Package", Price = 150.00m, AdditionalCost = 100m, AdditionalExtras = "4* Hotel", AvailableTickets = 100 };
            OasisCrokePark.Tickets.Add(OasisCrokeParkVIPTicket);

            Ticket ElectricPicnicStandardTicket = new Ticket() { Name = "Platinum", Price = 150.00m, AvailableTickets = 100 };
            ElectricPicnic.Tickets.Add(ElectricPicnicStandardTicket);

            Ticket ElectricPicnicVIPTicket = new Ticket.VIPTicket() { Name = "Weekend Ticket", Price = 200.00m, AdditionalCost = 100m, AdditionalExtras = "with camping", AvailableTickets = 100 };
            ElectricPicnic.Tickets.Add(ElectricPicnicVIPTicket);
            return new List<Event> { OasisCrokePark, ElectricPicnic };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Loads the events into the listbox
            List<Event> events = CreateEvent();
            lbx_Events.ItemsSource = events;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = txtBx_Search.Text;
        }

        private void lbx_Events_Selected(object sender, RoutedEventArgs e)
        {


        }

        private void lbx_Events_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Loads the tickets for an event into the listbox when an event is selected
            Event selectedEvent;

            selectedEvent = lbx_Events.SelectedItem as Event;

            lbx_Tickets.ItemsSource = selectedEvent.Tickets;
        }

        private void lbx_Tickets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ticket selectedTicket;

            selectedTicket = lbx_Tickets.SelectedItem as Ticket;


        }

        private void btn_BookTickets_Click(object sender, RoutedEventArgs e)
        {
            // Purchases tickets when the button is clicked, updates the available tickets appropriately
            Ticket selectedTicket = lbx_Tickets.SelectedItem as Ticket;

            int numberOfTicketsToBePurchased = int.Parse(txtBx_NumberOfTickets.Text.ToLower());

            if (selectedTicket.AvailableTickets >= numberOfTicketsToBePurchased)
            {
                selectedTicket.AvailableTickets -= numberOfTicketsToBePurchased;
                MessageBox.Show("Tickets have been purchased !");
            }
            else
            {
                MessageBox.Show("Not enough tickets available");
            }
        }

        private void txtBx_Search_KeyDown(object sender, KeyEventArgs e)
        {
            // Ran out of time to implement search functionality
        }
    }
}
