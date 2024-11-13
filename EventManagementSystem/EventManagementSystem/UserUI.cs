using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManagementSystem
{
    public class UserUI
    {
        private EventManager eventManager;
        private TicketManager ticketManager;
        private AccountManager accountManager;
        private TransactionManager transactionManager;
        private Account loggedInUser;

        public UserUI()
        {
            eventManager = new EventManager();
            ticketManager = new TicketManager(eventManager);
            accountManager = new AccountManager();
            transactionManager = new TransactionManager();
        }

        public void Register(string username, string password, bool isAdmin)
        {
            accountManager.RegisterAccount(username, password, isAdmin);
            Console.WriteLine($"{username} registered successfully.");
        }

        public void Login(string username, string password)
        {
            var account = accountManager.Login(username, password);
            if (account != null)
            {
                loggedInUser = account;
                Console.WriteLine($"{username} logged in successfully.");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        public void Logout()
        {
            if (loggedInUser != null)
            {
                Console.WriteLine($"{loggedInUser.Username} logged out successfully.");
                loggedInUser = null;
            }
            else
            {
                Console.WriteLine("No user is logged in.");
            }
        }

        public void AdminAddEvent(int eventId, string name, int numberOfTickets, double pricePerTicket, DateTime dateTime)
        {
            if (loggedInUser != null && loggedInUser.IsAdmin)
            {
                var newEvent = new Event(eventId, name, numberOfTickets, pricePerTicket, dateTime);
                eventManager.AddEvent(newEvent);
                transactionManager.RecordAddEvent(newEvent);
                Console.WriteLine("Event added successfully.");
            }
            else
            {
                Console.WriteLine("Only admin can add events.");
            }
        }

        public void AdminUpdateEvent(int eventId, string name, int numberOfTickets, double pricePerTicket, DateTime dateTime)
        {
            if (loggedInUser != null && loggedInUser.IsAdmin)
            {
                eventManager.UpdateEvent(eventId, name, numberOfTickets, pricePerTicket, dateTime);
                var updatedEvent = eventManager.ListEvents().FirstOrDefault(e => e.EventId == eventId);
                if (updatedEvent != null)
                {
                    transactionManager.RecordUpdateEvent(updatedEvent);
                }
                Console.WriteLine("Event updated successfully.");
            }
            else
            {
                Console.WriteLine("Only admin can update events.");
            }
        }

        public void AdminDeleteEvent(int eventId)
        {
            if (loggedInUser != null && loggedInUser.IsAdmin)
            {
                var eventToDelete = eventManager.ListEvents().FirstOrDefault(e => e.EventId == eventId);
                if (eventToDelete != null)
                {
                    eventManager.AdminDeleteEvent(loggedInUser, eventId);
                    transactionManager.RecordDeleteEvent(eventToDelete);
                    Console.WriteLine("Event deleted successfully.");
                }
            }
            else
            {
                Console.WriteLine("Only admin can delete events.");
            }
        }

        public void UserBookTicket(int eventId, bool pricePaid, DateTime bookingDate)
        {
            if (loggedInUser != null && !loggedInUser.IsAdmin)
            {
                var availableTickets = eventManager.ListEvents().FirstOrDefault(e => e.EventId == eventId)?.AvailableTickets;
                if (availableTickets != null && availableTickets.Count > 0)
                {
                    var ticketId = availableTickets.First().TicketId;
                    ticketManager.BookTicket(eventId, ticketId, pricePaid, bookingDate);
                    loggedInUser.BookTicket(ticketManager.Tickets.Last());
                    transactionManager.RecordBookTicket(ticketManager.Tickets.Last(), loggedInUser.Username);
                    Console.WriteLine("Ticket booked successfully.");
                }
                else
                {
                    Console.WriteLine("No tickets available for this event.");
                }
            }
            else
            {
                Console.WriteLine("User not logged in or is an admin.");
            }
        }

        public void UserCancelTicket(int ticketId)
        {
            if (loggedInUser != null && !loggedInUser.IsAdmin)
            {
                if (loggedInUser.TicketsBooked.ContainsKey(ticketId))
                {
                    var ticket = ticketManager.Tickets.FirstOrDefault(t => t.TicketId == ticketId);
                    if (ticket != null)
                    {
                        ticketManager.CancelTicket(ticketId);
                        loggedInUser.CancelTicket(ticketId);
                        transactionManager.RecordCancelTicket(ticket, loggedInUser.Username);
                        Console.WriteLine("Ticket canceled successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Ticket not found in user's bookings.");
                }
            }
            else
            {
                Console.WriteLine("User not logged in or is an admin.");
            }
        }

        public void ViewAllEvents()
        {
            var events = eventManager.ListEvents();
            foreach (var evt in events)
            {
                Console.WriteLine($"EventID: {evt.EventId}, Name: {evt.Name}, Tickets Available: {evt.AvailableTickets.Count}, Price: {evt.PricePerTicket}, Date: {evt.DateTime}");
            }
        }

        public void ViewMyTickets()
        {
            if (loggedInUser != null && !loggedInUser.IsAdmin)
            {
                foreach (var ticket in loggedInUser.TicketsBooked.Values)
                {
                    Console.WriteLine($"TicketID: {ticket.TicketId}, EventID: {ticket.EventId}, BookingDate: {ticket.BookingDate}, PricePaid: {ticket.PricePaid}");
                }
            }
            else
            {
                Console.WriteLine("User not logged in or is an admin.");
            }
        }

        public TransactionManager GetTransactionManager()
        {
            return transactionManager;
        }
    }
}
