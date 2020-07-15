using System;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class Registration
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
