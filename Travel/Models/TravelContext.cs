using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DestinationActivity> DestinationActivity { get; set; }
        public DbSet<DestinationAccomodation> DestinationAccomodation { get; set; }
        public DbSet<DestinationReview> DestinationReview { get; set; }

        public TravelContext(DbContextOptions<TravelContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          base.OnModelCreating(builder);
            builder.Entity<Destination>()
              .HasData(

                  new Destination { DestinationId = 1, City = "London", Country = "England"},
                  new Destination { DestinationId = 2, City = "Amsterdam", Country = "Netherlands"},
                  new Destination { DestinationId = 3, City = "Berlin", Country = "Germany"}
              );
        }
    }
}