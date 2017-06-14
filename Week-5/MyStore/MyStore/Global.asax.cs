using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MyStore.domainDB.Entities;
using MyStore.Infrastructure.Binders;

namespace MyStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //register model binding for cart
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinders());
        }
    }
}
