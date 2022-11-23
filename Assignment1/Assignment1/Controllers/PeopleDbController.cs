using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment1.controllers
{
    public class PeopleDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public PeopleDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.People.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Cities = new SelectList(_context.Cities, "CityId", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person, int cityId)
        {
            person.Id = Guid.NewGuid().ToString();

            var city = _context.Cities.Find(cityId);
            person.CityId = city.CityId;

            ModelState.Remove("PersonId");
            ModelState.Remove("City");

            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string personId)
        {
            var personToRemove = _context.People.Find(personId);

            if (personToRemove != null)
            {
                _context.People.Remove(personToRemove);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
