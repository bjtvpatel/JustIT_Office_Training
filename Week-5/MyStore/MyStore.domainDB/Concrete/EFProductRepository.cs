using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Entities;

namespace MyStore.domainDB.Concrete
{
    public class EFProductRepository:IProductRepository
    {
        private EFDbContext _context1 = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return _context1.Products; }
        }

        public void SaveProduct(Product product)
        {
            if(product.ProductId == 0)
            {
                _context1.Products.Add(product);
            }
            else
            {
                Product dbEntry = _context1.Products.Find(product.ProductId);
                if (dbEntry != null)
                {
                    dbEntry.ProductName = product.ProductName;
                    dbEntry.ProductDescription = product.ProductDescription;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    dbEntry.Author = product.Author;
                    dbEntry.ISBN = product.ISBN;
                    dbEntry.SubCategory = product.SubCategory;
                    dbEntry.Publisher = product.Publisher;
                    dbEntry.Image = product.Image;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;
                }
                
            }
            _context1.SaveChanges();
        }


        public Product DeleteProduct(int productId)
        {
            Product dbEntry = _context1.Products.Find(productId);
            if (dbEntry != null)
            {
                _context1.Products.Remove(dbEntry);
                _context1.SaveChanges();
            }
            return dbEntry;
        }
    }
}