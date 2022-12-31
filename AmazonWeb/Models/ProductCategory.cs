using System;
namespace AmazonWeb.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
        }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
