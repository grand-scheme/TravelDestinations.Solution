using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : IdentityDbContext<ApplicationUser>
    {
        
        public TravelContext(DbContextOptions<TravelContext> options)
          : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          base.OnModelCreating(builder);
            builder.Entity<Destination>()
              .HasData(

                  new Destination { DestinationId = 1, City = "London", Country = "England"},
                  new Destination { DestinationId = 2, City = "Amsterdam", Country = "Netherlands"},
                  new Destination { DestinationId = 3, City = "Berlin", Country = "Germany"},
                  new Destination { DestinationId = 4, City = "South Pole", Country = "Antartica"},
                  new Destination { DestinationId = 5, City = "Kyoto", Country = "Japan"},
                  new Destination { DestinationId = 6, City = "New York City", Country = "USA"},
                  new Destination { DestinationId = 7, City = "Ho Chi Minh", Country = "Vietnam"}
              );
        }
    }
}