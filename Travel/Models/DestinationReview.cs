namespace Travel.Models
{
  public class DestinationReview
  {
    public int DestinationReviewId { get; set; }
    public int DestinationId { get; set; }
    public int ReviewId { get; set; }
    public Destination Destination { get; set; }
    public Review Review { get; set; }
  }
}