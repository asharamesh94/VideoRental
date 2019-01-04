using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental_MVC.Models;

namespace VideoRental_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RandomMovie()
        {
            Movie movie = new Movie();
            movie.Name = "The Prower";
            return View(movie);
        }

        public ActionResult Edit(int? id)
        {
            if(!id.HasValue)
            {
                id = 1;
            }
            return Content("id:"+id);

        }

        public ActionResult Welcome()
        {
            return RedirectToAction("RandomMovie", "Movies");
        }

        public ActionResult ReleaseByDate(int month,int year)
        {
            return Content(string.Format($"Month:{month} <br/> Year:{year}"));
        }

 
    }
}