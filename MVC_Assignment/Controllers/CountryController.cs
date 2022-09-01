using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
