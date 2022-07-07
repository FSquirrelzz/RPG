using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters")]
        public string Username {get;set;}
        [Required]
        [StringLength(16,MinimumLength=8,ErrorMessage="You must specify a password between 8 and 16 characters")]
        public string Password {get;set;}
    }
}