using Assignment1.models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckAge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckAge(int input)
        {
            //if (input >= 18)
            //{
            //    ViewBag.Result = "You are old enough to vote!";
            //}
            //else
            //{
            //    ViewBag.Result = "You are not old enough to vote!";
            //}
            ViewBag.Result = CheckModel.CheckAge(input);
            return View();
        }
        public IActionResult SetSession()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetSession(string input)
        {
            if (input != null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddMinutes(5);
                HttpContext.Response.Cookies.Append("CookieMonster", input, options);
                HttpContext.Session.SetString("Session", input);
                ViewBag.Message = "Session and cookies have been set";
            }
            return View();
        }

        public IActionResult GetSession()
        {
            ViewBag.Session = HttpContext.Session.GetString("Session");
            ViewBag.Cookie = HttpContext.Request.Cookies["CookieMonster"];
            return View();
        }
    }
}
