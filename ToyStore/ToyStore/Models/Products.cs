using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToyStore.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Descripton { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }


        public virtual ICollection<Order> Orders { get; set; } 
    }
}