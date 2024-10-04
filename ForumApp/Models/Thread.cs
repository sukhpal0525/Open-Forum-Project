public class Thread
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ViewsCount { get; set; }
    public int RepliesCount { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }

    public ICollection<Post> Posts { get; set; }
}
