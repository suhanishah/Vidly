using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(){ Id = 1,Name = "Shrek"},
                new Movie(){Id = 2, Name = "Wall-E"}
            };
           
        }
        
        //public ActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Josh"};
        //    var customers = new List<Customer>
        //    {
        //        new Customer(){Name = "Customer 1"},
        //        new Customer(){Name ="Customer 2"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };
        //    return View(viewModel);
        //}

        //[Route("movies/released/{year}/{month: regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, byte month)
        //{
        //    return Content(year +"/" + month);
        //}
    }


}