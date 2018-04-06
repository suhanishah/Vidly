using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //Get - a lits of customers - /api/customers
        public IEnumerable<MovieDto> GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.Genre)
                .Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));

            return moviesQuery
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);


        }

        //Get - a single customer - /api/customers/1
        public IHttpActionResult GetMovie(int id)

        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();
            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //Add/Create a movie /api/movie

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovie)]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        //Update a customer - /api/customers/1 - decorate httpput
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovie)]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.Include(m => m.Genre.GenreName).SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return NotFound();

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();

            return Ok();
        }
        //Delete a customer - /api/customers/1 - decorate httpdelete
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovie)]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb
                = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return NotFound();


            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();
        }


    }
}