using Lighten_2.Data;
using Lighten_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lighten_2.Controllers
{
    public class BlogController : Controller
    {
        private readonly Lighten_2DbContext _context;
        public BlogController(Lighten_2DbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blog.ToList();
            return View(blogs);
        }
    }
}
