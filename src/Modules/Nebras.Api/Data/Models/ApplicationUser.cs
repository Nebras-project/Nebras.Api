using Microsoft.AspNetCore.Identity;

namespace Nebras.Api.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Username { get; set; } = default!;
        public string? ProfileImage { get; set; }
    }
}
