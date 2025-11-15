namespace Nebras.Api.Data.Models
{
    public class Grade
    {
        public Guid Id { get; set; } = Guid.CreateVersion7();
        public string Name { get; set; } = string.Empty;

        public ICollection<StudentProfile> Students { get; set; } = [];
    }
}
