﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private TravelContext _db;
    
        public DestinationsController(TravelContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Destination>> Get(string city, string country)
        {
            var query = _db.Destinations.AsQueryable();

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }

            if (country != null)
            {
                query = query.Where(entry => entry.Country == country);
            }

            return query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Destination> Get(int id)
        {
            return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Destination destination)
        {
            _db.Destinations.Add(destination);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Destination destination)
        {
            destination.DestinationId = id;
            _db.Entry(destination).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var destinationToDelete = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
            _db.Destinations.Remove(destinationToDelete);
            _db.SaveChanges();
        }
    }
}
