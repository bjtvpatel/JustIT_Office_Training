using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Entities;

namespace MyStore.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        private IProductRepository _repository;

        public AdminController(IProductRepository repo)
        {
            _repository = repo;

        }
       

        public ViewResult Index()
        {
            return View(_repository.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product products = _repository.Products
                .FirstOrDefault(p => p.ProductId == productId);

            return View(products);

        }

        [HttpPost]
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(product.ImageData, 0, image.ContentLength);
                        

                }
                _repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been updated", product.ProductName);
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the data values 
                return View(product);
            }

        }

        public ViewResult Create()
        {
                       
            return View("Edit", new Product());

        }

        public ActionResult Delete(int productId)
        {
            Product deleteProduct = _repository.DeleteProduct(productId);
            if (deleteProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deleteProduct.ProductName);
            }

            return RedirectToAction("Index");

        }
    }
}