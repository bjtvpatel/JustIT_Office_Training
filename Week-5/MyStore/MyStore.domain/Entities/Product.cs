using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStore.domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string SubCategory { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public byte Image { get; set; }


    }
}