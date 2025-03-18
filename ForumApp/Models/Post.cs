using System.ComponentModel.DataAnnotations;

public class Post
{
    public int Id { get; set; }

    [Required]
    public required string Content { get; set; }
    
    public required DateTime CreatedDate { get; set; }
    
    public required int ForumThreadId { get; set; }
    public required ForumThread ForumThread { get; set; }

    public required int AuthorId { get; set; }
    public required User Author { get; set; }
}
