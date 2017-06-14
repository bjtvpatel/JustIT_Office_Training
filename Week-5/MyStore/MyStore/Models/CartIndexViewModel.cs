using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.domainDB.Entities;

namespace MyStore.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }
    }
}