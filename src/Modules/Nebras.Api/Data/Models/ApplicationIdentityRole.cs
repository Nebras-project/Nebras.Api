using Microsoft.AspNetCore.Identity;

namespace Nebras.Api.Data.Models
{
    public class ApplicationIdentityRole : IdentityRole<Guid>
    {
        public ApplicationIdentityRole() 
        {
            Id = Guid.CreateVersion7();
        }
    }
}
