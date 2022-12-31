using System;
namespace AmazonWeb.Models
{
    public class Contact
    {
        public Contact()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }
}
