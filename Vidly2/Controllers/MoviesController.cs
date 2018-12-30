using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return Content("Movies Controller - Index action");
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Matrix" };
            //return View(movie);
            return Content("Hello World!");
            //return HttpNotFound();
        }
    }
}
