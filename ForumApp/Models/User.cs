public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Role { get; set; }  // Admin, Moderator, Member
    public string? AvatarUrl { get; set; }
    public ICollection<Post> Posts { get; set; }
}
