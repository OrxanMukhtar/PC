using Microsoft.AspNetCore.Mvc;

namespace Lighten_2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
