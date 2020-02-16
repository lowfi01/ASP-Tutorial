using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Tutorial.Models;

namespace ASP_Tutorial.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Life" };

            ViewData["Movie"] = movie;

            return View();
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {

            // Using default params 
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


        [Route("Movie/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }

}