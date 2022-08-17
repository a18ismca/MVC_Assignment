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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
