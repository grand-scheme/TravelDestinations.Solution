namespace Travel.Models
{
  public class DestinationActivity
  {
    public int DestinationActivityId { get; set; }
    public int DestinationId { get; set; }
    public int ActivityId { get; set; }
    public Destination Destination { get; set; }
    public Activity Activity { get; set; }
  }
}