using System;
using Microsoft.AspNetCore.Identity;

namespace AmazonWeb.Models
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set;}
    }
}