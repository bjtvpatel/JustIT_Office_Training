using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.domainDB.Entities;

namespace MyStore.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }

        public string SearchItem { get; set; }
        public string CurrentFiler { get; internal set; }
    }


}