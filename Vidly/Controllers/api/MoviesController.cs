using System;
using System.Net;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Controllers.api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/movies
        [HttpGet]
        public IEnumerable<MovieDto> GetMovie()
        {
            return _context.Movies
                .Include(m => m.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);
        }

        // GET /api/customers?query=abc
        public IHttpActionResult GetMovie(string query)
        {
            return Ok(_context.Movies
                .Where(c => c.Name.Contains(query))
                .Include(c => c.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>));
        }

        // GET /api/movies/1
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // POST /api/movies
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + @"/" + movieDto.Id), movieDto);
        }

        // PUT /api/movies/1
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(movieDto, movie);

            _context.SaveChanges();
        }

        // DELETE /api/movies/1
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}