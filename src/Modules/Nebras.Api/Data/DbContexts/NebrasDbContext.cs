using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nebras.Api.Data.DbContexts.Configurations;
using Nebras.Api.Data.Models;

namespace Nebras.Api.Data.DbContexts
{
    public class NebrasDbContext : IdentityDbContext<ApplicationUser, ApplicationIdentityRole, Guid>
    {
        public DbSet<StudentProfile> StudentProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StudentProfileConfiguration());
        }
    }
}
