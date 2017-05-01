using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInv_MVC.Models;

namespace PartyInv_MVC.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ViewResult Index()
        {
            //return View();
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();

        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            //return View();
           
            return View();

        }
        [HttpPost]
        public ViewResult RsvpForm( GuestResponse guestresponse)
        {
            if (ModelState.IsValid)
            {
                //TODo: Email response to the party organiser
                return View("Thanks", guestresponse);

            }
            else
            {
                //there is a validation error
                return View();

            }

        }
        

        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "Hello World";
        //}
    }
}