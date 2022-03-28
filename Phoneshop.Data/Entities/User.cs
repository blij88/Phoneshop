using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Phoneshop.Data.Entities
{
    public class User:Base
    {
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required, Phone]
        public int PhoneNumber { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int Type { get; set; }
        public bool Active { get; set; } = false;
        public double Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public IList<Order> Orders { get; set; }
    }
}