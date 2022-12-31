using System;
namespace AmazonWeb.Models
{
    public class ImageProduct
    {
        public ImageProduct()
        {
        }
        public int Id { get; set; }
        public string LinkImage { get; set; }
        public int ProductId { get; set; }
        public bool IsPreview { get; set; }
        public Product Product { get; set; }
    }
}
