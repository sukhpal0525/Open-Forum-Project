using System.ComponentModel.DataAnnotations;

public class Post
{
    public int Id { get; set; }

    [Required]
    public string Content { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public int ThreadId { get; set; }
    public ForumThread ForumThread { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }
}
