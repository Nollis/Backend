using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CountryDBController : Controller
    {
        readonly ApplicationDbContext _context;

        public CountryDBController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cities = _context.Countries.Include(p => p.Cities).ToList();
            //return View(_context.Countries.ToList());
            return View(cities);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Add(country);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int countryId)
        {
            var countryToRemove = _context.Countries.Find(countryId);

            if(countryToRemove != null)
            {
                _context.Countries.Remove(countryToRemove);
                _context.SaveChanges(true);
            }

            return RedirectToAction("Index");
        }
    }
}
