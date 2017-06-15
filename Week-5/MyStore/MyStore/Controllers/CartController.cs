using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Entities;
using MyStore.Models;

namespace MyStore.Controllers
{
    public class CartController : Controller
    {
        //repository declaration
        private IProductRepository _repository;
        private IOrderProcessor orderProcessor;

        //constructor for dependency resolver
        public CartController(IProductRepository repo, IOrderProcessor proc)
        {
            _repository = repo;
            orderProcessor = proc;
        }

        //add to cart each item
        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product!=null)
            {
                cart.AddItem(product,1);
                //GetCart().AddItem(product, 1);
            }
            return RedirectToAction("Index", new {returnUrl});

        }

        //remove item from current cart
        public RedirectToRouteResult RemoveFromCart(Cart cart,int productId, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
                //GetCart().RemoveLine(product);
            }
            return RedirectToAction("Index", new {returnUrl});

        }

        //removed when modelbinder were implemented which will provide current cart object
        //private Cart GetCart()
        //{
        //    Cart cart = (Cart) Session["Cart"];
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //        Session["Cart"] = cart;
        //    }
        //    return cart;
        //    // throw new NotImplementedException();
        //}

        // GET: Cart
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                //Cart = GetCart(), 
                ReturnUrl = returnUrl

            });
        }

        //cart summary
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        //display shipping detail page
        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        //submit order
        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (!cart.Lines.Any())
            {
                ModelState.AddModelError("", "Sorry, your cart is empty");
            }
            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            return View(new ShippingDetails());
        }
    }
}