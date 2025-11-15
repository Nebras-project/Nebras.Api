using System;
using Microsoft.AspNetCore.Identity;

namespace Nebras.Api.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            // Initialise new users with a time-ordered GUID v7
            Id = Guid.CreateVersion7();
        }

        public string? ProfileImage { get; set; }

        public StudentProfile Student { get; set; }
    }
}
