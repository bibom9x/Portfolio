using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManagementSystem
{
    public class TicketManager
    {
        private EventManager eventManager;

        public List<Ticket> Tickets { get; private set; }

        public TicketManager(EventManager eventManager)
        {
            this.eventManager = eventManager;
            Tickets = new List<Ticket>();
        }

        public bool CanBookTicket(int eventId)
        {
            var eventDetails = eventManager.Events.FirstOrDefault(e => e.EventId == eventId);
            return eventDetails != null && eventDetails.AvailableTickets.Count > 0;
        }

        public bool CanCancelTicket(int ticketId)
        {
            return Tickets.Any(t => t.TicketId == ticketId);
        }

        public void BookTicket(int eventId, int ticketId, bool pricePaid, DateTime bookingDate)
        {
            var eventToBook = eventManager.Events.FirstOrDefault(e => e.EventId == eventId);
            if (eventToBook != null)
            {
                var ticket = eventToBook.AvailableTickets.FirstOrDefault(t => t.TicketId == ticketId);
                if (ticket != null)
                {
                    ticket.SetPricePaid(pricePaid);
                    ticket.SetBookingDate(bookingDate);
                    eventToBook.BookTicket(ticket);
                    Tickets.Add(ticket);
                }
            }
        }

        public void CancelTicket(int ticketId)
        {
            var ticketToCancel = Tickets.FirstOrDefault(t => t.TicketId == ticketId);
            if (ticketToCancel != null)
            {
                var eventToUpdate = eventManager.Events.FirstOrDefault(e => e.EventId == ticketToCancel.EventId);
                if (eventToUpdate != null)
                {
                    eventToUpdate.CancelTicket(ticketId);
                    Tickets.Remove(ticketToCancel);
                }
            }
        }

        public List<Ticket> ListTickets(int eventId)
        {
            return Tickets.Where(t => t.EventId == eventId).ToList();
        }
    }
}
