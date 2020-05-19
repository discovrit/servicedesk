using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wotw.servicedesk.Models
{
    public class TicketViewModel
    {
        public TicketViewModel() { }

        public TicketViewModel(List<Ticket> tickets)
        {
            Tickets = tickets;            
        }

        public List<Ticket> Tickets { get; set; }
    }
}
