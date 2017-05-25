using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using TechMVCDatabase.Models;
using System.Net;
using PagedList;


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

        public ActionResult Index(string techCategory, string techBrand, string searchString, string currentFilter, int? page)
        {
            //pagging code starts
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;
            //pagging code ends

            //brand
            var brandList = new  List<string>();
            var brandQuery = from b in db.TechDetails orderby b.Brand select b.Brand;

            brandList.AddRange(brandQuery.Distinct());
            ViewBag.techBrand = new SelectList(brandList);
            
            //category
            var categoryList = new List<string>();
            var categoryQuery = from c in db.TechDetails orderby c.Category select c.Category;

            categoryList.AddRange(categoryQuery.Distinct());
            ViewBag.techCategory = new SelectList(categoryList,techCategory);

            //get all techdetail
            var techdata = from t in db.TechDetails
                select t;
           
            //brand search
            if (!string.IsNullOrEmpty(searchString))
            {
                techdata = techdata.Where(s => s.ModelName.Contains(searchString)).OrderBy(s=>s.ModelName);
               
            }


            //model searcgh -2 get all models of choosen model from db
            if (!string.IsNullOrEmpty(techBrand))
            {
                techdata = techdata.Where(x => x.Brand == techBrand).OrderBy(x=>x.Brand);
         
            }

            //category serach
            if (!string.IsNullOrEmpty(techCategory))
            {
                techdata = techdata.Where(x => x.Category == techCategory).OrderBy(x=>x.Category);
            }

            //without Paging
            //return View(techdata);
            //pagging code starts
            //with paging 
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(techdata.OrderByDescending(x => x.Price).ToPagedList(pageNumber, pageSize));
            //pagging code ENDS
        }


        public ActionResult About()
        {
            ViewBag.Message = "Tech-Gadget Record Management System.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me.";

            return View();
        }

        public ActionResult CreatRecord()
        {
            return View();
        }

        //public ActionResult CreatRecord(string techCategory)
        //{

        //    //category list
        //    var categoryList = new List<string>();
        //    var categoryQuery = from c in db.TechDetails orderby c.Category select c.Category;

        //    categoryList.AddRange(categoryQuery.Distinct());
        //    ViewBag.techCategory = new SelectList(categoryList);

        //    return View();
        //}
        [HttpPost]
        public ActionResult CreatRecord(TechDetail techDetail)
        {
            //if model state is not valid then retur to creat so use can fix it

            if (!ModelState.IsValid)
            {
                return View(techDetail);
            }
           
            //if data is valid
            db.TechDetails.Add(techDetail);
            db.SaveChanges();
            return RedirectToAction("Index");

           
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

        [HttpPost]
        public ActionResult DeleteRecord(int id)
        {
            TechDetail techDetail = db.TechDetails.Find(id);
            db.TechDetails.Remove(techDetail);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}