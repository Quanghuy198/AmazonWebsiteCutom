using System;
namespace AmazonWeb.Models
{
    public class Cart
    {
        public Cart()
        {
        }
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Quantity { get; set; }
        public int Price { get; set; }
    }
}
