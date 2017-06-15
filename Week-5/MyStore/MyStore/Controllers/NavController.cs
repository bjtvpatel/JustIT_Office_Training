using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Abstract;

namespace MyStore.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository _repository;

        public NavController(IProductRepository repo)
        {
            _repository = repo;
        }


        public PartialViewResult Menu(string category = null, bool horizontalLayout = false)
        {
            
            ViewBag.SelectedCategory = category;
            IEnumerable<string> subcategories = _repository.Products
                .Select(x => x.SubCategory)
                .Distinct()
                .OrderBy(x => x);

            string viewName = horizontalLayout ? "MenuHorizontal" : "Menu";

            return PartialView(viewName, subcategories);
        }

        public PartialViewResult SubMenu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            
        IEnumerable<string> categories = _repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);

            return PartialView(categories);

        }
        // GET: Nav
        //public string Menu()
        //{
        //    return "Hello from NavController";
        //}
    }
}