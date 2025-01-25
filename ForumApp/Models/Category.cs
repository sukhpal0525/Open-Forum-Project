using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(100)]
    public string Description { get; set; }
    
    public List<Thread> Threads { get; set; } = new List<Thread>();
}