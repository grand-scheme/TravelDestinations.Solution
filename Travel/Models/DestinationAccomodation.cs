namespace Travel.Models
{
  public class DestinationAccomodation
  {
    public int DestinationAccomodationId { get; set; }
    public int DestinationId { get; set; }
    public int AccomodationId { get; set; }
    public Destination Destination { get; set; }
    public Accomodation Accomodation { get; set; }
  }
}