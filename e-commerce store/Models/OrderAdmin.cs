using E_commerce_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce_store.Models
{
    public class OrderAdmin
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int AdminId { get; set; }
        public Admin Admins { get; set; }


        public ICollection<OrderItem> OrderItems { get; set; }
    }
}