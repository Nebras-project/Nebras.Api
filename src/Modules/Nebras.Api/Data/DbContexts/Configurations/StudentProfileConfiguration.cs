using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nebras.Api.Data.Models;

namespace Nebras.Api.Data.DbContexts.Configurations
{
    public class StudentProfileConfiguration : IEntityTypeConfiguration<StudentProfile>
    {
        public void Configure(EntityTypeBuilder<StudentProfile> builder)
        {
            builder.ToTable("StudentProfiles");

            
            builder.HasKey(s => s.UserId);

            
            builder.Property(s => s.UserId)
                   .ValueGeneratedNever();

            
            builder.HasOne(s => s.User)
                   .WithOne(s => s.Student)
                   .HasForeignKey<StudentProfile>(s => s.UserId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(s => s.grade)
                   .WithMany(g => g.Students)
                   .HasForeignKey(s => s.GradeId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
