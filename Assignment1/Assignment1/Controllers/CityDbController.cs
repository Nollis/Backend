using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            var CountryCity = _context.Cities.Include(p => p.Country).ToList();
            //return View(_context.Cities.ToList());
            return View(CountryCity);
        }

        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(_context.Countries, "CountryId", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(City city, int countryId)
        {
            var country = _context.Countries.Find(countryId);
            city.CountryId = country.CountryId;

            ModelState.Remove("Country");

            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int cityId)
        {
            var cityToRemove = _context.Cities.Find(cityId);

            if (cityToRemove != null)
            {
                _context.Cities.Remove(cityToRemove);
                _context.SaveChanges(true);
            }

            return RedirectToAction("Index");
        }
    }
}
