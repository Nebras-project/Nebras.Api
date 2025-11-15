namespace Nebras.Api.Data.Models
{
    public class StudentProfile
    {
        public Guid UserId { get; set; } = Guid.CreateVersion7();
        public ApplicationUser User { get; set; }

        public Guid GradeId { get; set; }
        public Grade grade { get; set; }
    }
}
