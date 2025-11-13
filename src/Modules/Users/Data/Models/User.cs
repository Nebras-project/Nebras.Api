namespace Nebras.Api.Data.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string? PhoneNumber { get; set; }
    public string? ProfileImage { get; set; }
    public string HashedPassword { get; set; } = default!;
    public int UserRoleId { get; set; }
    public UserRole? UserRole { get; set; }


    public static void HashPassword(string password)
    {
        // has password and set it to HashedPassword
    }
}
