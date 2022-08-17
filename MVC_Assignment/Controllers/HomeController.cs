using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
