using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using MVC_Practice.Models;

namespace MVC_Practice.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!!"};
            
           
            return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page=1,sortby="name"});


        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }

        //public ActionResult Index(int? pageIndex, string sortby)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortby))
        //        sortby = "Name";

        //    return Content((string.Format("pageIndex={0}&sortby={1}", pageIndex, sortby)));

        //}
        [Route("Movie/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }   
}