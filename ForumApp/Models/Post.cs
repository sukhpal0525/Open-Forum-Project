public class Post
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    
    public int ThreadId { get; set; }
    public Thread Thread { get; set; }

    public int AuthorId { get; set; }
    public User Author { get; set; }
}
