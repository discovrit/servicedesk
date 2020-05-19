using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wotw.servicedesk.Models;

namespace wotw.servicedesk.Service
{
    public interface ITicketService
    {
        List<Ticket> GetTickets(int number);
        Ticket GetById(int id);
    }
}
