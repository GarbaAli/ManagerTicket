namespace ManagerTicket.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string?  Titre { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; } = false;
        public DateTime CreatedAd { get; set; }
        public ICollection<Categorie>? Categories { get; set; }
        public int UserId { get; set; }
        public int TechnicalId { get; set; }
        public User? User { get; set; }
    }
}
