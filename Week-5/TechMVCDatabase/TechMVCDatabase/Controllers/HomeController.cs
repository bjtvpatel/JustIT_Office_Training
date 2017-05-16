using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using TechMVCDatabase.Models;
using System.Net;

namespace TechMVCDatabase.Controllers
{
    public class HomeController : Controller
    {

       TechMVCDatabaseEntities db = new TechMVCDatabaseEntities();

       
        //public ActionResult Index()
        //{
        //    var techdata = from t in db.TechDetails
        //                  select t;

        //    return View(techdata);
        //}

        public ActionResult Index(string techCategory, string techBrand, string searchString)
        {
            //brand
            var brandList = new  List<string>();
            var brandQuery = from b in db.TechDetails orderby b.Brand select b.Brand;

            brandList.AddRange(brandQuery.Distinct());
            ViewBag.techBrand = new SelectList(brandList);

            //category
            var categoryList = new List<string>();
            var categoryQuery = from c in db.TechDetails orderby c.Category select c.Category;

            categoryList.AddRange(categoryQuery.Distinct());
            ViewBag.techCategory = new SelectList(categoryList);

            //get all techdetail
            var techdata = from t in db.TechDetails
                select t;
           
            //brand search
            if (!String.IsNullOrEmpty(searchString))
            {
                techdata = techdata.Where(s => s.ModelName.Contains(searchString));
            }

            //model searcgh -2 get all models of choosen model from db
            if (!String.IsNullOrEmpty(techBrand))
            {
                techdata = techdata.Where(x => x.Brand == techBrand);
         
            }

            //category serach
            if (!String.IsNullOrEmpty(techCategory))
            {
                techdata = techdata.Where(x => x.Category == techCategory);
            }

            return View(techdata);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreatRecord(string techCategory)
        {
            
            //category list
            var categoryList = new List<string>();
            var categoryQuery = from c in db.TechDetails orderby c.Category select c.Category;

            categoryList.AddRange(categoryQuery.Distinct());
            ViewBag.techCategory = new SelectList(categoryList);

            return View();
        }
        [HttpPost]
        public ActionResult CreatRecord(TechDetail techDetail)
        {
            //if data is valid 
            if (ModelState.IsValid)
            {
                db.TechDetails.Add(techDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //if model state is not valid then retur to creat so use can fix it

            return View(techDetail);

        }

        public ActionResult EditRecord(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TechDetail techDetail = db.TechDetails.Find(id);

            if (techDetail == null)
            {
                return HttpNotFound();
            }
            return View(techDetail);

        }
        [HttpPost]
        public ActionResult EditRecord(TechDetail techDetail)
        {
            //if data is valid then save in database
            if (ModelState.IsValid)
            {
                db.Entry(techDetail).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //if data not valid then return to edit page to fix the problem
            
            return View(techDetail);

        }

        public ActionResult DetailRecord(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TechDetail techDetail = db.TechDetails.Find(id);

            if (techDetail == null)
            {
                return HttpNotFound();
            }
            return View(techDetail);

        }

        public ActionResult DeleteRecord(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TechDetail techDetail = db.TechDetails.Find(id);

            if (techDetail == null)
            {
                return HttpNotFound();
            }
            return View(techDetail);

        }


    }
}