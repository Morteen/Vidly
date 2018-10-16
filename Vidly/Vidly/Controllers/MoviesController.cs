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
        public ActionResult Random()
        {
            
            var movie = new Movie(){ Name="Shrek!"};
            var customers = new List<Customer>
            {
                new Customer{ Name="Customer 1"},
                new Customer{ Name="Customer 2"}
            };

            //Lager en viewModel for å send ut i Random viewet
            var viewModel = new RandomViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;

            return View(viewModel);
        }
        [Route("movies/released/{year}/{month}:regex(\\d{2}):range(1,12)")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}