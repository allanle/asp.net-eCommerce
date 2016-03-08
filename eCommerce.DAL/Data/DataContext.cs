using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Data
{
    public class DataContext : DbContext
    {
        // Pass the Name of a connection string or explicitly declare it
        public DataContext() : base("DefaultConnection")
        {

        }

        // Entity to be persisted must be declared here.
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
