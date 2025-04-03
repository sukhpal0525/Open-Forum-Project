using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ForumThread> ForumThreads { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map UserRole enum to string
            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();
            
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.Author)
                .HasForeignKey(p => p.AuthorId);



            modelBuilder.Entity<Category>()
                .HasMany(c => c.ForumThreads)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId);



            modelBuilder.Entity<ForumThread>()
                .HasMany(t => t.Posts)
                .WithOne(p => p.ForumThread)
                .HasForeignKey(p => p.ForumThreadId);


        // Seed Data
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Administrator", Role = UserRole.Admin },
                new User { Id = 2, Username = "John", Role = UserRole.Member }
            );

            // Insert Categories first
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "General Discussion", Description = "Talk about anything here" },
                new Category { Id = 2, Name = "Announcements", Description = "Official announcements from the team" }
            );

            // Then insert ForumThreads that reference them
            modelBuilder.Entity<ForumThread>().HasData(
                new ForumThread { Id = 1, Title = "Welcome to the Forum", RepliesCount = 5, ViewsCount = 100, CategoryId = 1, AuthorId = 1 },
                new ForumThread { Id = 2, Title = "Forum Rules", RepliesCount = 3, ViewsCount = 50, CategoryId = 2, AuthorId = 2 }
            );
        }
    }
}
