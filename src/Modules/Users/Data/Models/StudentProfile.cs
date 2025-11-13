namespace Nebras.Api.Data.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }
        // !temp
        public string Grad { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
