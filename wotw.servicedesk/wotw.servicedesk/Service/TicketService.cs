using System;
using wotw.servicedesk.Models;

namespace wotw.servicedesk.Service
{
    public class TicketService : ITicketService
    {
        public Ticket GetById(int id)
        {
            return GetMockTicketById(id);
        }

        private Ticket GetMockTicketById(int id)
        {
            return new Ticket
            {
                Id = id,
                Title = $"New Ticket - Number {id}",
                Description = $"New Ticket - Number {id} Decription"
            };
        }
    }
}
