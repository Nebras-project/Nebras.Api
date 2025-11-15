namespace Nebras.Api.Data.Models
{
    public class Student
    {
        public Guid UserId { get; set; } = Guid.CreateVersion7();
        // here will be student profile
    }
}
