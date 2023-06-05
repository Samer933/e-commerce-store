using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Models
{
    public class OrderCustomer
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
