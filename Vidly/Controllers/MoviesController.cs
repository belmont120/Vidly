using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = new Movie() { Id = 1, Name = "Shrek!" };

            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Wall-e" }
            };

            var viewModel = new IndexMoviesViewModel()
            {
                Movies = movies
 
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Wall-e" }
            };

            var movie = new Movie();
            {
                movie = movies.Single(c => c.Id == id);
            };

            return View(movie);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}