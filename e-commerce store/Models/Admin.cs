using e_commerce_store.Models;
using E_commerce_store.Attribiuts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Models
{
    public class Admin
    {

        public int Id { get; set; }

        [NameLengthAttribute]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [EmailDomain("gmail.com", "hotmail.com", "icloud.com")]
        public string Email { get; set; }



        [Required(ErrorMessage = "The address field is required !!")]
        [Display(Name = "Address")]
        [RegularExpression(@"^[a-zA-Z0-9\s\.,]+$", ErrorMessage = "Please enter a valid address.")]
        public string Address { get; set; }


        [Required]
        [Display(Name = "Phone")]
        [Range(6, 20, ErrorMessage = "Please enter a valid phone number between 6 and 20.")]
        public int Phone { get; set; }

        public ICollection<OrderAdmin> Orders { get; set; }
        public ICollection<Product> products { get; set; }




    }
}
