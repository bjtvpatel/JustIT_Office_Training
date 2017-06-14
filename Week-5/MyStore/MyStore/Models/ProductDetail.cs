using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.domainDB.Entities;

namespace MyStore.Models
{
    public class ProductDetail
    {
        public IEnumerable<Product> Products { get; set; }

       
    }
}