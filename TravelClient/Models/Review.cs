using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public int DestinationId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int Rating { get; set; }
    public Destination Destination { get; set; }

    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelperReviews.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }

    public static Review GetDetails(int id)
    {
      var apiCallTask = ApiHelperReviews.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }

    public static void Post(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ApiHelperReviews.Post(jsonReview);
    }

    public static void Put(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ApiHelperReviews.Put(review.ReviewId, jsonReview);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelperReviews.Delete(id);
    }
  }
}