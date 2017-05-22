using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Practice.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace MVC_Practice.Controllers.Tests
{
    [TestClass()]
    public class HelloControllerTests
    {
        [TestMethod()]
        public void ExecuteTest()
        {
            var controller = new HelloController();
            controller.Execute(new RequestContext());
           
        }
    }
}