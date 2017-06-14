using System;
using System.Collections.Generic;
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
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernalParam)
        {
            _kernel = kernalParam;
            AddBindings();

        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IProductRepository>().To<EFProductRepository>();


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