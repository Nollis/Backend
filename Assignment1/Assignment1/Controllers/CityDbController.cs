using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CityDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public CityDbController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            return View(_context.Cities.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var cityToRemove = _context.Countries.Find(Id);

            if (cityToRemove != null)
            {
                _context.Countries.Remove(cityToRemove);
                _context.SaveChanges(true);
            }

            return RedirectToAction("Index");
        }
    }
}
