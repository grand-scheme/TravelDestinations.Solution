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

        // add seeded data here after inital migration
    }
}