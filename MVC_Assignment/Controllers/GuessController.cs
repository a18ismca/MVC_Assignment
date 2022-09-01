using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class GuessController : Controller
    {

        string sessionString = "ismets_session";


        public IActionResult Index()
        {
            
            int randomNumber = GameModel.GetRandomNumber();

            ViewBag.Result = randomNumber.ToString();

            HttpContext.Session.SetString(sessionString, randomNumber.ToString());

            return View();
        }

        [HttpPost]
        public IActionResult Index(int guessedNumber)
        {
            //int randomNumber = GameModel.GetRandomNumber();


            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(sessionString)))
            {

                //int parseInt = int.Parse(HttpContext.Session.GetString(sessionString));

                if (GameModel.GetResult(guessedNumber, int.Parse(HttpContext.Session.GetString(sessionString))) == true)
                {
                    ViewBag.Result = GameModel.Statement;

                    HttpContext.Session.SetString(sessionString, GameModel.NewRandomNumber.ToString());


                    return View();
                }
                else
                {
                    ViewBag.Result = GameModel.Statement;
                }
            }

            return View();
        }
    }
}

