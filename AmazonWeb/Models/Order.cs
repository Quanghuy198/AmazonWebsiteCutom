using System;
using System.Collections.Generic;

namespace AmazonWeb.Models
{
    public class Order
    {
        public Order()
        {
        }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }

        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public int Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
