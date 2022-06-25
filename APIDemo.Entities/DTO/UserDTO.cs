using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Entities.DTO
{
    public class UserDTO
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public String DateOfBirth { get; set; }
        public string Country { get; set; }
    }
}