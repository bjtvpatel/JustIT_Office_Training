using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Concrete;
using MyStore.domainDB.Entities;
using Ninject;


namespace MyStore.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        //depenency resolver 
        private IKernel _kernel;

       // constructior
        public NinjectDependencyResolver(IKernel kernalParam)
        {
            _kernel = kernalParam;
            AddBindings();

        }

        //
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        //binding
        private void AddBindings()
        {
            _kernel.Bind<IProductRepository>().To<EFProductRepository>();

            EmailSettings emailSettings = new EmailSettings
            {
                WriteAsFile = bool.Parse(ConfigurationManager.AppSettings["Email.WriteAsFile"]??"false")

            };

            _kernel.Bind<IOrderProcessor>().To<EmailOrderProcessor>()
                .WithConstructorArgument("settings", emailSettings);

            _kernel.Bind<IAuthProvider>().To<FormAuthProvider>();

            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product {ProductName = "Harypotter", Price = 25},
            //    new Product {ProductName = "HalfGirlFriend", Price = 20},
            //    new Product {ProductName = "TwoStates", Price = 15},
            //    new Product {ProductName = "Border", Price = 5},
            //});

            //_kernel.Bind<IProductRepository>().ToConstant(mock.Object);
            //   throw new NotImplementedException();
        }
    }
}