using System.ComponentModel.DataAnnotations;

public class Thread
{
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; }
    
    public int RepliesCount { get; set; }
    public int ViewsCount { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }
    
    public int CategoryId {get; set; }
    public Category Category {get; set; }

    public List<Post> Posts { get; set; } = new List<Post>();
}