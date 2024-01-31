using Lighten_2.Data;
using Lighten_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lighten_2.Controllers
{
    public class AboutController : Controller
    {
        private readonly Lighten_2DbContext _context;
        public AboutController(Lighten_2DbContext context)
        { 
        _context = context;
        }
        public IActionResult Index()
        {
            About?about= _context.About.FirstOrDefault();
            return View(about);
        }
    }
}
