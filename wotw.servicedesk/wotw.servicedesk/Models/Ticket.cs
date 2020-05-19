namespace wotw.servicedesk.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string RequestorName { get; set; }

        public string RequestorEmail { get; set; }

        public int Priority { get; set; }
    }
}
