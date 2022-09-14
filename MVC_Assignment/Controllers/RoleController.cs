using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
