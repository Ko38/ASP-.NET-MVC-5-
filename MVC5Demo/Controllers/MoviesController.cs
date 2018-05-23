using MVC5Demo.Models;
using MVC5Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class MoviesController : Controller
    {
        //ViewResult

        // GET: Movies
        //ViewResult
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Id = 1,
                Name = "Hangover"
            };

            var customers = new List<Customer>
            {
                new Customer{Name="Customer 1" },
                new Customer{Name="Customer 2"}
            };
            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model;

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        //:regex(\\d{2}):range(1,12)
        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content($"{year} {month}");
        }
    }
}