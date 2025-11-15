namespace Nebras.Api.Data.Models
{
    public class StudentProfile
    {
        public Guid UserId { get; set; } = Guid.CreateVersion7();
    }
}
