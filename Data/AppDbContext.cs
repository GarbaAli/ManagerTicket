using ManagerTicket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ManagerTicket.Data
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasOne<User>(u => u.User)
                .WithMany(t => t.Tickets)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<Ticket>()
                .HasOne<User>(u => u.User)
                .WithMany(t => t.Tickets)
                .HasForeignKey(u => u.TechnicalId);
        }

        public DbSet<Ticket>? Tickets { get; set; } 
        public DbSet<Categorie>? Categories { get; set; }

    }
}
