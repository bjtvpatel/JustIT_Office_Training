using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Entities;
using MyStore.Models;
using MyStore.HtmlHelpers;
using Ninject.Infrastructure.Language;

namespace MyStore.Controllers
{
    public class ProductController : Controller
    {
        //repository declaration
        private IProductRepository _repository;
        public int PageSize = 6;

        //constructor for dependency resolver
        public ProductController(IProductRepository productRepository)
        {
            this._repository = productRepository;

        }
        //GET: Product
        //public ViewResult List()
        //{
        //    return View(_repository.Products);
        //}

        //GET products from db to list
        public ViewResult List(string category, int page = 1)
        {           

            ProductListViewModel model = new ProductListViewModel
            {
                
                Products = _repository.Products
                .Where(p => category == null || p.SubCategory.ToLower() == category.ToLower())
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    Totalitems = category == null ? _repository.Products.Count() : _repository.Products.Count(e => e.SubCategory.ToLower() == category.ToLower())
                },
                CurrentCategory = category
                               
            };


            return View(model);

            //  return View(_repository.Products.OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize));
        }

        ////GET products from db to list
        //public ViewResult Search(string searchString, int page = 1)
        //{
        //    ProductListViewModel model = new ProductListViewModel
        //    {

        //        Products = _repository.Products
        //        .Where(p => searchString == null || p.SubCategory.ToLower() == searchString)
        //        .OrderBy(p => p.ProductId)
        //        .Skip((page - 1) * PageSize)
        //        .Take(PageSize),

        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = page,
        //            ItemsPerPage = PageSize,
        //            Totalitems = searchString == null ? _repository.Products.Count() : _repository.Products.Count(e => e.SubCategory.ToLower() == searchString)
        //        },
        //        CurrentCategory = searchString
        //    };
        //    return View(model);
        //    //  return View(_repository.Products.OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize));

        //}

        //Get product details for detail view
        public ActionResult ProductDetail(int id)
        {
            // IEnumerable<Product> productD =_repository.Products.Where(p => p.ProductId == id);

            Product productD = _repository.Products.FirstOrDefault(p => p.ProductId == id);

            return View(productD);
        }

        //retrieve image from db
        public FileContentResult GetImage(int productId)
        {
            Product prod = _repository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (prod != null)
            {
                return File(prod.ImageData, prod.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
       
    }
}