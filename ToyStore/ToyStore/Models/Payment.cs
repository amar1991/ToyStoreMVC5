using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToyStore.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CardNo { get; set; }
        public string Type { get; set; }
        public string ExpiryDate { get; set; }
        public string AccountHolderName { get; set; }
        public int CVSNo { get; set; }


        public void Authorization()
        {
            

        }


    }
}