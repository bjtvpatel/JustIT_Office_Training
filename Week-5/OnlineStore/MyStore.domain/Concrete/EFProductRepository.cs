using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.domain.Abstract;
using MyStore.domain.Entities;

namespace MyStore.domain.Concrete
{
    public class EFProductRepository:IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}