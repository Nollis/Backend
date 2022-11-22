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
            var person = _context.People.Include(x=>x.City).FirstOrDefault(x=>x.PersonId == id);

            ViewBag.Name = person.Name;
            ViewBag.PersonId = person.PersonId;

            return View(person.City);
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
            var person = _context.People.Include(x => x.City).FirstOrDefault(x => x.PersonId == personId);
            var city = _context.Cities.Find(cityId);

            if(!person.City.CityId.Equals(city.CityId))
            {
                _context.Cities.Add(person);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.People, "Id", "Name");
                ViewBag.Cities = new SelectList(_context.Cities.Where(x=>x.CityId != cityId), "Id", "Name");
                ViewBag.Message = "You already added this City to this person.";
                return View();
            }

            return RedirectToAction("Index", new { id = personId }); 
        }

        public IActionResult RemoveCityfromPerson(string personId, int cityId)
        {
            var person = _context.People.Include(x => x.City).FirstOrDefault(x => x.PersonId == personId);
            var cityToRemove = _context.Cities.Find(cityId);

            person.City.Remove(cityToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = personId });
        }
    }
}
