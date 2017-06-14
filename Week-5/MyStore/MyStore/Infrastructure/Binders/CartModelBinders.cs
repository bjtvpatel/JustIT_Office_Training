using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.domainDB.Entities;



namespace MyStore.Infrastructure.Binders
{
    public class CartModelBinders: IModelBinder
    {
        private const string sessionKey = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //get the cart from session
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null)
            {
                cart = (Cart) controllerContext.HttpContext.Session[sessionKey];
            }

            //create a cart there was no cart in session data
            if (cart == null)
            {
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = cart;
                }
            }

            //return the car

            return cart;
            // throw new NotImplementedException();
        }

        
    }
}