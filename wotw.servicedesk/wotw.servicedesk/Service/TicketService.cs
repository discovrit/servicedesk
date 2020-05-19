using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using wotw.servicedesk.Models;

namespace wotw.servicedesk.Service
{
    public class TicketService : ITicketService
    {
        public Ticket GetById(int id)
        {
            return GetMockTicketById(id);
        }

        public List<Ticket> GetTickets(int number)
        {
            List<Ticket> tickets = new List<Ticket>();
            for (int i = 0; i < number; i++)
            {
                tickets.Add(GetMockTicketById(i));
            }

            return tickets;
        }

        private Ticket GetMockTicketById(int id)
        {
            var rnd = new Random();
            var priority = rnd.Next(1, 5);
            var email = $"email{id}@address.com";

            return new Ticket
            {
                Id = id,
                Title = $"New Ticket - Number {id}",
                Description = $"New Ticket - Number {id} Decription",
                RequestorName = $"New Ticket - Number {id}",
                RequestorEmail = email,
                Priority = priority

            };
        }
    }
}
