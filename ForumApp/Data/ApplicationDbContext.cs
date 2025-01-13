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

                // Map UserRole enum to string
                modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();


            modelBuilder.Entity<Category>()
                .HasMany(c => c.Threads)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId);


            modelBuilder.Entity<Thread>()
                .HasMany(t => t.Posts)
                .WithOne(p => p.Thread)
                .HasForeignKey(p => p.ThreadId);


            // Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "General Discussion", Description = "Talk about anything here" },
                new Category { Id = 2, Name = "Announcements", Description = "Official announcements from the team" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Administrator", Role = UserRole.Admin },
                new User { Id = 2, Username = "John", Role = UserRole.Member }
            );

            modelBuilder.Entity<Thread>().HasData(
                new Thread { Id = 1, Title = "Welcome to the Forum", RepliesCount = 5, ViewsCount = 100, CategoryId = 1, AuthorId = 1 },
                new Thread { Id = 2, Title = "Forum Rules", RepliesCount = 3, ViewsCount = 50, CategoryId = 2, AuthorId = 2 }
            );
        }
    }
}
