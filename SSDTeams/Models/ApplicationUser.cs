using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// Class for Registered Users
namespace SSDTeams.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        override
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        override
        public string Email { get; set; }
        [Phone]
        override
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }




    }
}
