using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Abstract;


namespace MyStore.Controllers
{
    public class StartupController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 6;

        public StartupController(IProductRepository productRepository)
        {
            this._repository = productRepository;

        }
        // GET: Startup
        public ActionResult Index()
        {
            IEnumerable<string> subcategories = _repository.Products
                .Select(x => x.SubCategory)
                .Distinct()
                .OrderBy(x => x);

            return View(subcategories);
        }
    }
}