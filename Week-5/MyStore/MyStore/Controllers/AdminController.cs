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
        //repository declaration
        private IProductRepository _repository;

        //contructor for dependency resolver
        public AdminController(IProductRepository repo)
        {
            _repository = repo;

        }
       
        //GET all product list
        public ViewResult Index()
        {
            return View(_repository.Products);
        }

        //EDIT the product from list
        public ViewResult Edit(int productId)
        {
            Product products = _repository.Products
                .FirstOrDefault(p => p.ProductId == productId);

            return View(products);

        }

        //UPDATE product and also use this for creating a new product
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

        //GET empty from for new product
        public ViewResult Create()
        {
                       
            return View("Edit", new Product());

        }

        //DELETE method
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