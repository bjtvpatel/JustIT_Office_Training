using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStore.domainDB.Entities
{
    public class CartLine
    {
       
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}