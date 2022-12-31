using System;
using System.Collections.Generic;

namespace AmazonWeb.Models
{
    public class Language
    {
        public Language()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<Category> Categories { get; set; }
    }
}
