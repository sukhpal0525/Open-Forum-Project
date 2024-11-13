using Microsoft.AspNetCore.Mvc;
using ForumApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ForumController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Action for displaying threads in a category
        public IActionResult Category(int id)
        {
            var category = _context.Categories
                .Include(c => c.Threads)
                .ThenInclude(t => t.Author) // Include author of each thread
                .FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // Action for displaying posts in a thread
        public IActionResult Thread(int id)
        {
            var thread = _context.Threads
                .Include(t => t.Posts)
                .ThenInclude(p => p.Author) // Include author of each post
                .FirstOrDefault(t => t.Id == id);

            if (thread == null)
            {
                return NotFound();
            }

            return View(thread);
        }
    }
}
