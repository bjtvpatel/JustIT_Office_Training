using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using MyStore.domainDB.Abstract;

namespace MyStore.Infrastructure
{
    public class FormAuthProvider:IAuthProvider
    {
        //user authentication
        public bool Authenticate(string username, string password)
        {
            //set the authentican 
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                //set cookies 
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;

        }
    }
}