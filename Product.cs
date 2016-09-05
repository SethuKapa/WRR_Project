using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WRR301_Project.Models
{
    public class Product
    {
        public char ProductID {get; set; }
        public string ProdDescription { get; set; }
        public double Price { get; set; }
        public string ShopName { get; set; }
        public char OnSale { get; set; }
    }

    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}