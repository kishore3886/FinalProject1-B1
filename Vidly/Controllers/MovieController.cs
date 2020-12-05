using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie() {Name="Bahubali" };

            var customers = new List<Customer> 
            { 
                   new Customer{Name="Kishore"}
                  // new Customer{Name="Naren"}

            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };
            //return Content("hello world");
            //return HttpNotFound();


            //return new EmptyResult();

            //name of the action, controller, parameters (anonymous object)
            //return RedirectToAction("Index","Home", new { page=1, sortBy= "Name" } );
            return View(viewModel);
        }
   
    
    }
}