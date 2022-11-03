using Microsoft.AspNetCore.Mvc;

namespace Assignment1.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Curriculum Vitae";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Contacts";
            return View();
        }

    }
}
