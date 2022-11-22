using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.Countries = new SelectList(_context.Countries, "CountryId", "CountryName");
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

        public IActionResult Delete(int Id)
        {
            var cityToRemove = _context.Cities.Find(Id);

            if (cityToRemove != null)
            {
                _context.Cities.Remove(cityToRemove);
                _context.SaveChanges(true);
            }

            return RedirectToAction("Index");
        }
    }
}
