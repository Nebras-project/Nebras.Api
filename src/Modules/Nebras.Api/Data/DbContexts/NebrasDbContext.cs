using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nebras.Api.Data.DbContexts.Configurations;
using Nebras.Api.Data.Models;

namespace Nebras.Api.Data.DbContexts
{
    public class NebrasDbContext(DbContextOptions<NebrasDbContext> options) : IdentityDbContext<ApplicationUser, ApplicationIdentityRole, Guid>(options)
    {
        public DbSet<StudentProfile> StudentProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new StudentProfileConfiguration());
        }
    }
}
