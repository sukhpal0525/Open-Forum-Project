using System.Data.Entity;
using Forum.Models;

namespace ForumApp.Data
{
    public class ForumContext : DbContext
    {
        public ForumContext() : base("ForumContext")
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
