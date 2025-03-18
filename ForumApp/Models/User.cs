using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [MaxLength(50)]
    public required string Username { get; set; }
    
    public required UserRole Role { get; set; }  // Admin, Moderator, Member

    [MaxLength(500)]
    public string? AvatarUrl { get; set; }

    public ICollection<Post>? Posts { get; set; }
}

public enum UserRole { Owner, Admin, Member }