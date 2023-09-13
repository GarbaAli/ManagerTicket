namespace ManagerTicket.Models
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Libelle { get; set; } = string.Empty;
        public ICollection<Ticket>? Tickets { get; set; } 
    }
}
