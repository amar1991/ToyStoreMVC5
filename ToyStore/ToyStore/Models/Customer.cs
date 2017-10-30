using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToyStore.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        public virtual ICollection<Order> Orders { get; set; }





    }


}