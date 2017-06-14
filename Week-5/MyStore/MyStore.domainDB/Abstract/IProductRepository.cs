using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.domainDB.Entities;

namespace MyStore.domainDB.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
       
        //update item from list
        void SaveProduct(Product product);

        //delete item from list
        Product DeleteProduct(int ProductId);
    }
}
