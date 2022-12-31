using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AmazonWeb.Models;

namespace AmazonWeb
{
    public class Product
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
        public ProductTranslation ProductTranslation { get; set; }
        public List<Cart> Carts { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ImageProduct> Images { get; set; }
    }
}