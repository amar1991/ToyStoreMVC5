using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToyStore.Models;

namespace ToyStore.Context
{
    public class ProductDBContext : DbContext
    {
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Order> orders { get; set; }
        public virtual DbSet<Products> products { get; set; }
        public virtual DbSet<Payment> payments { get; set; }
    }
}