﻿using E_commerce_store.Attribiuts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
        public int Phone { get; set; }





        /*  [Required]
          [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
          [DataType(DataType.Password)]
          [Display(Name = "Password")]
          public string Password { get; set; }

          [DataType(DataType.Password)]
          [Display(Name = "Confirm password")]
          [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
          public string ConfirmPassword { get; set; }*/





        public ICollection<OrderCustomer> Orders { get; set; }
    }
}
