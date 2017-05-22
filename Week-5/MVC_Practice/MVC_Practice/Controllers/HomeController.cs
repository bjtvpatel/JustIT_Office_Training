using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Practice.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ViewResult Index()
        {
            ViewBag.Message = "This is view from Index method.";

            var data = from p in Process.GetProcesses() select p;

            return View(data);
        }
        //public ActionResult About()
        //{
        //    ViewBag.Messahe = "Thid is about section from Index page";

        //    return View();
        //}

        public ActionResult About(int id)
        {
            var process = (from p in Process.GetProcesses()
                           where p.Id == id
                           select p).Single();

            
            return View(process);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}