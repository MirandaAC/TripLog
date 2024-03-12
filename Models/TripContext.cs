using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace TripLog.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Trip>().ToTable("Trips").HasData(
                new Trip { 
                    Id = 1,
                    Destination = "Portland",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Accomodation = "The Benson Hotel",
                    Phone = "503-555-1234",
                    Email = "staff@thebenson.com",
                    Thingstodo1 = "Get Voodoo donuts",
                    Thingstodo2 = "Walk in the rain",
                    Thingstodo3 = "Go to Powell's"
                },
                new Trip
                {
                    Id = 2,
                    Destination = "Boise",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now, 
                    Accomodation = "Holiday Inn Express",
                    Thingstodo1 = "Visit Family"
                }
                );
        }

    }
}
