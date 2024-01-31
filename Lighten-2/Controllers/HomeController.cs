using Lighten_2.Data;
using Lighten_2.Models;
using Lighten_2.Views;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Lighten_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lighten_2DbContext _context;
        public HomeController(Lighten_2DbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            HomeViewModel homeView = new HomeViewModel();
            {
                //Products products= _context.Products.ToList();  
                

            }
            return View();
        }
    }
}
