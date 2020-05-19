using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
            var rnd = new Random();
            var count = rnd.Next(1, 10000);
            List<Ticket> tickets = _ticketService.GetTickets(count);

            TicketViewModel model = new TicketViewModel(tickets);

            return View(model); 
        }


        public IActionResult Ticket(int id)
        {
            Ticket ticket = _ticketService.GetById(id);
            return View(ticket);
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
