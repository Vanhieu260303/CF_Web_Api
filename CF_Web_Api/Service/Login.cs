using System.ComponentModel.DataAnnotations;

namespace CF_Web_Api.Service
{
    public class Login
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
