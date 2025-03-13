using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }

    [StringLength(50)]
    public required string Name { get; set; }

    [Required]
    [StringLength(100)]
    public string Description { get; set; }
    
    public List<ForumThread> ForumThreads { get; set; } = new List<ForumThread>();
}