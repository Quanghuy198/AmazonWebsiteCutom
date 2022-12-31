using System;
namespace AmazonWeb.Models
{
    public class OrderDetail
    {
        public OrderDetail()
        {
        }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Quantity { get; set; }
        public int Price { get; set; }
    }
}
