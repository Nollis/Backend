using Microsoft.AspNetCore.Mvc;

namespace Assignment1.controllers
{
    public class GuessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NumbGuess()
        {
            if (HttpContext.Session.GetInt32("rndNumber") == null)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 100);
                HttpContext.Session.SetInt32("rndNumber", num);
            }

            return View();
        }

        [HttpPost]
        public IActionResult NumbGuess(int input)
        {
            int num = (Int32)HttpContext.Session.GetInt32("rndNumber");
            if (input > num)
            {
                ViewBag.Result = "You guessed too high! Guess again.";
            }
            else if (input < num)
            {
                ViewBag.Result = "You guessed too low! Guess again.";
            }
            else if (input == num)
            {
                ViewBag.Result = "You guessed correct! (a new number has been generated)";
                Random rnd = new Random();
                int newnum = rnd.Next(0, 100);
                HttpContext.Session.SetInt32("rndNumber", newnum);
            }
            else
            {
                ViewBag.Result = "That is not a valid entry, try again...";
            }

            return View();
        }
    }
}
