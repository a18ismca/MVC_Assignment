using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class GuessController : Controller
    {

        string sessionString = "ismets_session";
        public IActionResult GuessingGame()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(sessionString))){
                int randomNumber = GameModel.GetRandomNumber();

                GameModel.CorrectAnswer = randomNumber;

                HttpContext.Session.SetString(sessionString, randomNumber.ToString());


            }
            else
            {
               GameModel.CorrectAnswer = int.Parse(HttpContext.Session.GetString(sessionString));  
            }

        return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int guessedNumber)
        {
            if (guessedNumber <= 0 || guessedNumber > 100)
            {
                ViewBag.Result = "Please enter a number between 1 and 100!";
            }
            ViewBag.Result = GameModel.GetResult(guessedNumber);

            return View();

        }
    }
}
