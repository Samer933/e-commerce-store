using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int AdminId { get; set; }
        public Admin Admin { get; set; }


        public ICollection<OrderItem> OrderItems { get; set; }
    }

}