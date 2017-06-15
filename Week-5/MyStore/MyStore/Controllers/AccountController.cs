using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Abstract;
using MyStore.Models;

namespace MyStore.Controllers
{
    public class AccountController : Controller
    {

        IAuthProvider _authProvider;

        //constructor for dependency resolver 
        public AccountController(IAuthProvider auth)
        {
            _authProvider = auth;
        }
        
        public ViewResult Login()
        {
            return View();
        }

        //login POST method
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if(_authProvider.Authenticate(model.Username, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        
    }
}