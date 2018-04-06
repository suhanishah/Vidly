using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //api/newRentals
        [HttpPost]
        public IHttpActionResult GetNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(m => m.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("This movie is not available.");

                movie.NumberAvailable--;
                var rental = new NewRental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.NewRentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }

    }

}
