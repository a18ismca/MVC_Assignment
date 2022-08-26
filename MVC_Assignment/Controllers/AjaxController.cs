using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
