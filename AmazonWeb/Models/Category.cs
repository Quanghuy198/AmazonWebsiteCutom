using System;
using System.Collections.Generic;

namespace AmazonWeb.Models
{
    public class Category
    {
        public Category()
        {
        }
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
