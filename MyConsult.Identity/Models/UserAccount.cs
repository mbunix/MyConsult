

using Microsoft.AspNetCore.Identity;

namespace MyConsult.Identity.Models
{
    public class ApplicationUser:IdentityUser  
    {
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}