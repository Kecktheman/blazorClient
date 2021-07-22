using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorClientMovies.Models
{
    public class User
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "default@test.se";

        [Required]
        [MinLength(8, ErrorMessage = "Password needs to be 8 characters or longer.")]
        public string Password { get; set; } = "iamlongerthaneightchars";

        public string ErrorMessage { get; set; }
    }
}
