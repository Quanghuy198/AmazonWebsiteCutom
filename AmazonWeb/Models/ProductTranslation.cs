using System;
using System.Collections.Generic;

namespace AmazonWeb.Models
{
    public class ProductTranslation
    {
        public ProductTranslation()
        {
        }

        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
