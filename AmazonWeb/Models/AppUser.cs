using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AmazonWeb.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName {get; set;}
        public string LastName{get; set;}

        public List<Order> Orders { get; set; }
    }
}