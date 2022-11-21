using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class PersonCityDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public PersonCityDbController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string id)
        {
            var person = _context.People.Include(x=>x.Cities).FirstOrDefault(x=>x.Id == id);

            ViewBag.Name = person.Name;
            ViewBag.PersonId = person.Id;

            return View(person.Cities);
        }

        public IActionResult AddCountryToPerson()
        {
            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            ViewBag.Cities = new SelectList(_context.Cities, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult AddCityToPerson(string personId, int cityId)
        {
            var person = _context.People.Include(x => x.Cities).FirstOrDefault(x => x.Id == personId);
            var city = _context.Cities.Find(cityId);

            if(!person.Cities.Any(c=>c.Id == city.Id))
            {
                person.Cities.Add(city);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.People, "Id", "Name");
                ViewBag.Countries = new SelectList(_context.Countries.Where(x=>x.Id != cityId), "Id", "Name");
                ViewBag.Message = "You already added this Country to this person.";
                return View();
            }

            return RedirectToAction("Index", new { id = personId }); 
        }

        public IActionResult RemoveCityfromPerson(string personId, int cityId)
        {
            var person = _context.People.Include(x => x.Cities).FirstOrDefault(x => x.Id == personId);
            var cityToRemove = _context.Cities.Find(cityId);

            person.Cities.Remove(cityToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = personId });
        }
    }
}
