using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person, int cityId)
        {
            person.PersonId = Guid.NewGuid().ToString();

            var city = _context.Cities.Find(cityId);
            person.City = city;

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

        public IActionResult Delete(Person person, int cityId)
        {
            var personToRemove = _context.Cities.Find(cityId);
            person.City = personToRemove;

            if (personToRemove != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
