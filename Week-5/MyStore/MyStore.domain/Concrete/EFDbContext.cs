using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyStore.domain.Entities;

namespace MyStore.domain.Concrete
{
    public class EFDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }


    }
}