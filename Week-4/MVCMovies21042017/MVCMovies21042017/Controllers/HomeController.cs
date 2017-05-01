using MVCMovies21042017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCMovies21042017.Controllers
{
    public class HomeController : Controller
    {

        private Movies210417BPEntities db = new Movies210417BPEntities();
        // GET: Home
        //public ActionResult Index()
        //{
        //    var movies = from m in db.Movies
        //                 select m;

        //    return View(movies);
        //}

        public ActionResult Index( string movieGenre, string searchString)
        {

            //genre
            //1. get genre from database to make dropdown list
            var GenreList = new List<string>();
            var GenreQuery = from g in db.Movies
                             orderby g.Genre
                             select g.Genre;
            GenreList.AddRange(GenreQuery.Distinct());
            ViewBag.movieGenre = new SelectList(GenreList);

            //get all movies
            var movies = from m in db.Movies
                         select m;

            //title search
            if(!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
            //genre search 2 - get moviews of choosen genre from db
            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);

            }

            return View(movies);
        }


        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();

            }
            return View(movie);
            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
           

            //if the data is valid, save it in the DB and 
            //return to the Index page
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //if data isnot valid return to create
            //page so user can fix it
            return View(movie);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();

            }
            return View(movie);

        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {


            //if the data is valid, save it in the DB and 
            //return to the Index page
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            //if data isnot valid return to create
            //page so user can fix it
            return View(movie);

        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();

            }
            return View(movie);

        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
           
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();

            return RedirectToAction("Index");

        }


    }
}