using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Hardcoded list of categories with dummy data
        var categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "General Discussion",
                Description = "Talk about anything here",
                Threads = new List<ForumThread>
                {
                    new ForumThread { Id = 1, Title = "Welcome to the Forum", RepliesCount = 5, ViewsCount = 100 }
                }
            },
            new Category
            {
                Id = 2,
                Name = "Announcements",
                Description = "Official announcements from the team",
                Threads = new List<ForumThread>
                {
                    new ForumThread { Id = 2, Title = "Forum Rules", RepliesCount = 3, ViewsCount = 50 }
                }
            }
        };

        // Pass the hardcoded data to the view
        return View(categories);
    }
}
}