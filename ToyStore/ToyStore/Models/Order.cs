using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToyStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer customers { get; set; }

        public int? ProductId { get; set; }
        public virtual Products products { get; set; }

        public int? PaymentId { get; set; }
        public virtual Payment payments { get; set; }
        

        public void CalcTotal(int Quantity, int Price)
        { 

         
        }


    }
    

}