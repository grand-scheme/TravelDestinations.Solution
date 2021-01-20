using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Travel.Models
{
  public class Destination
  {
    public Destination()
    {
      this.Reviews = new HashSet<Review>();
    }

    public int DestinationId { get; set; }
    [Required]
    public string City { get; set;}
    [Required]
    public string Country { get; set; }

    public ICollection<Review> Reviews { get; set; }
  }
}