using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;
namespace MVC_Assignment.Controllers
{
    public class DoctorController : Controller
    {
        // GET: DoctorController
        public ActionResult FeverCheck()
        {
            
            return View();
        }

        // GET POST ACTION
        [HttpPost]
        public ActionResult FeverCheck(float temperature)
        {
            
                ViewBag.Msg = FeverModel.CheckFever(temperature);
            
           

            return View();
        }

        
    }
}
