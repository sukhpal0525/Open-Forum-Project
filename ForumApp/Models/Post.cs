using System.ComponentModel.DataAnnotations;

public class Post
{
    public int Id { get; set; }

    [Required]
    public required string Content { get; set; }
    
    public required DateTime CreatedDate { get; set; }
    
    public int ForumThreadId { get; set; }
    public ForumThread ForumThread { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }
}
