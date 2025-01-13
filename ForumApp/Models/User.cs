using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }
    
    [Required]
    public UserRole Role { get; set; }  // Admin, Moderator, Member
    
    [MaxLength(500)]
    public string? AvatarUrl { get; set; }
    
    public ICollection<Post> Posts { get; set; }
}

public enum UserRole { Owner, Admin, Member }