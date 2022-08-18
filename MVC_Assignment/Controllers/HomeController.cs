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
            string description = "My name is Ismet Catovici" +
                "and I am 23 years old. Right now I study a påbyggnadsutbildning @ Lexicon and " +
                "live in Gbg. I have taken my bachelor's diploma in Informatics - specialization" +
                " in systems development March 2022. My hobbies are roadtrips abroad, hanging out w/ friends and spend " +
                "time with my family. ";

            ViewBag.Info = description;
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contact()
        {
            string Name = "Ismet Catovic";
            string Email = "ismetctvc@hotmall.sé";
            long PhoneNumber = 46707678703;

            ViewBag.Name = Name;
            ViewBag.Email = Email;
            ViewBag.PhoneNumber = PhoneNumber;
            return View();
        }
    }
}
