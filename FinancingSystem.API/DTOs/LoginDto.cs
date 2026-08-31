using System.ComponentModel.DataAnnotations;

namespace FinancingSystem.API.DTOs
{
    public class LoginDto
    {
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}