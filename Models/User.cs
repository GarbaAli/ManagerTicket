using Microsoft.AspNetCore.Identity;

namespace ManagerTicket.Models
{
    public class User:IdentityUser
    {
        public string? FirtName{ get; set; }
        public string? LastName { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
    }
}
