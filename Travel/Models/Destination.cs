using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    [Required]
    public string City { get; set;}
    [Required]
    public string Country { get; set; }
  }
}