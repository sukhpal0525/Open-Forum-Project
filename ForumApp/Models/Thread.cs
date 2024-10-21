public class Thread
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int RepliesCount { get; set; }
    public int ViewsCount { get; set; }
    public User? Author { get; set; }
    public List<Post> Posts { get; set; } = new List<Post>();

    public int CategoryId {get; set; }

    public Category Category {get; set; }
}