using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.Author)
                .HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Threads)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId);

            modelBuilder.Entity<Thread>()
                .HasMany(t => t.Posts)
                .WithOne(p => p.Thread)
                .HasForeignKey(p => p.ThreadId);
        }
    }
}
