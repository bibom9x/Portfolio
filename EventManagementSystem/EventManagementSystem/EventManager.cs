﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManagementSystem
{
    public class EventManager
    {
        public List<Event> Events { get; private set; }

        public EventManager()
        {
            Events = new List<Event>();
        }

        public void AddEvent(Event newEvent)
        {
            Events.Add(newEvent);
        }

        public void RemoveEvent(int eventId)
        {
            var eventToRemove = Events.FirstOrDefault(e => e.EventId == eventId);
            if (eventToRemove != null)
            {
                Events.Remove(eventToRemove);
            }
        }

        public List<Event> ListEvents()
        {
            return Events;
        }

        public void UpdateEvent(int eventId, string name, int tickets, double pricePerTicket, DateTime dateTime)
        {
            var eventToUpdate = Events.FirstOrDefault(e => e.EventId == eventId);
            if (eventToUpdate != null)
            {
                eventToUpdate.Name = name;
                eventToUpdate.NumberOfTickets = tickets;
                eventToUpdate.PricePerTicket = pricePerTicket;
                eventToUpdate.DateTime = dateTime;
                eventToUpdate.UpdateAvailableTickets();
            }
        }

        public void AdminDeleteEvent(Account adminAccount, int eventId)
        {
            if (adminAccount.IsAdmin && adminAccount.Username == "admin")
            {
                RemoveEvent(eventId);
                Console.WriteLine("Event deleted successfully.");
            }
            else
            {
                Console.WriteLine("Only admin can delete events.");
            }
        }

        public void AdminUpdateEvent(Account adminAccount, int eventId, string name, int tickets, double pricePerTicket, DateTime dateTime)
        {
            if (adminAccount.IsAdmin && adminAccount.Username == "admin")
            {
                var eventToUpdate = Events.FirstOrDefault(e => e.EventId == eventId);
                if (eventToUpdate != null && !eventToUpdate.HasTicketsBooked())
                {
                    UpdateEvent(eventId, name, tickets, pricePerTicket, dateTime);
                    Console.WriteLine("Event updated successfully.");
                }
                else if (eventToUpdate != null && eventToUpdate.HasTicketsBooked())
                {
                    Console.WriteLine("Cannot update event because tickets have been booked.");
                }
            }
            else
            {
                Console.WriteLine("Only admin can update events.");
            }
        }
    }
}
