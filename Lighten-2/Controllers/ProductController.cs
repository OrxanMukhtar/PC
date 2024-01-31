using Lighten_2.Data;
using Lighten_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Lighten_2.Controllers
{
    public class ProductController : Controller
    {
        private readonly Lighten_2DbContext _context;
        public ProductController( Lighten_2DbContext context)
        {
                _context = context;
        }
        public IActionResult Index()

        {
            List <Products> products=_context.Products.ToList();    
            return View(products );
        }
    }
}
