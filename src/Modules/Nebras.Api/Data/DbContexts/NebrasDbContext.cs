using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nebras.Api.Data.Models;

namespace Nebras.Api.Data.DbContexts
{
    public class NebrasDbContext : IdentityDbContext<ApplicationUser, ApplicationIdentityRole, Guid>
    {
        public DbSet<StudentProfile> Students { get; set; }
    }
}
