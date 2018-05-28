using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviely.Models;
using Moviely.ViewModels;

namespace Moviely.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        /*public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }*/


        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);    
        }



        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Interstellar" },
                new Movie { Id = 2, Name = "Jurassic Park" },
                new Movie { Id = 3, Name = "Avatar" },
                new Movie { Id = 4, Name = "Back to the Future" }
            };
        }






        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex= {0}&sortBy={1}", pageIndex, sortBy));
        }

       
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate( int year, int month)
        {
            return Content(year + "/" + month);
        }
        */
    }
}