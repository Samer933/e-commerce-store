using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }



        public int OrderId { get; set; }
        public OrderCustomer Order { get; set; }



        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
