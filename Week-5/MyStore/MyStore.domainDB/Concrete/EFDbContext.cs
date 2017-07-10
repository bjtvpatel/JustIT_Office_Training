using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyStore.domainDB.Entities;

namespace MyStore.domainDB.Concrete
{
    //db setup
    public class EFDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }

        //public DbSet<Category> Categories { get; set; }

        //public DbSet<SubCategory> SubCategories { get; set; }
    }
}