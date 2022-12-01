using Microsoft.AspNetCore.Identity;
using System;

namespace Assignment1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthDate { get; set; }
    }
}
