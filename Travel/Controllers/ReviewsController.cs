using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private TravelContext _db;
    
        public ReviewsController(TravelContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get()
        {
            // ViewBag.DestinationId = new SelectList(_db.Destinations, "DestinationId", "City");
            var query = _db.Reviews.AsQueryable();
            return query.ToList();
            // NOTE: SINCE THIS IS FOR SEARCHING FOR AN INDIVIDUAL ENTRY IN THE API,
            // THIS SHOULD LATER BE BUILT TO TARGET THE DESTINATION ID
            // AND RETURN REVIEWS ASSOCIATED W/ THAT DESTINATION
        }

        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
        }

        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Review review)
        {
            review.ReviewId = id;
            _db.Entry(review).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
            _db.Reviews.Remove(reviewToDelete);
            _db.SaveChanges();
        }
    }
}
