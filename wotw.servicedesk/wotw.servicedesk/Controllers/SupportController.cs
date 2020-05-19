using Microsoft.AspNetCore.Mvc;
using wotw.servicedesk.Models;
using wotw.servicedesk.Service;

namespace wotw.servicedesk.Controllers
{
    public class SupportController : Controller 
    {
        private readonly ITicketService _ticketService;

        public SupportController()
        {
            _ticketService = new TicketService();
        }


        public IActionResult Index()
        {
            return View();        
        }

        public IActionResult MyTickets()
        {
            return View(); 
        }


        public IActionResult Ticket(int id)
        {
            Ticket ticket = _ticketService.GetById(id);

            ViewData["TicketId"] = ticket.Id;
            ViewData["TicketTitle"] = ticket.Title;
            ViewData["TicketDesc"] = ticket.Description;

            return View();
        }

        public IActionResult Edit()
        {
            ViewData["Title"] = "Edit";
            return View();
        }
        public IActionResult New()
        {
            ViewData["Title"] = "New";
            return View("Edit");
        }
    }
}
