using Assignment1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class PersonCountryDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public PersonCountryDbController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string id)
        {
            var person = _context.People.Include(x=>x.Countrys).FirstOrDefault(x=>x.Id == id);

            ViewBag.Name = person.Name;
            ViewBag.PersonId = person.Id;

            return View(person.Countrys);
        }

        public IActionResult AddCountryToPerson()
        {
            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            ViewBag.Countries = new SelectList(_context.Countries, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult AddCountryToPerson(string personId, int countryId)
        {
            var person = _context.People.Include(x => x.Countrys).FirstOrDefault(x => x.Id == personId);
            var country = _context.Countries.Find(countryId);

            if(!person.Countrys.Any(c=>c.Id == country.Id))
            {
                person.Countrys.Add(country);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.People, "Id", "Name");
                ViewBag.Countries = new SelectList(_context.Countries.Where(x=>x.Id != countryId), "Id", "Name");
                ViewBag.Message = "You already added this Country to this person.";
                return View();
            }

            return RedirectToAction("Index", new { id = personId }); 
        }

        public IActionResult RemoveCountryfromPerson(string personId, int countryId)
        {
            var person = _context.People.Include(x => x.Countrys).FirstOrDefault(x => x.Id == personId);
            var countryToRemove = _context.Countries.Find(countryId);

            person.Countrys.Remove(countryToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = personId });
        }
    }
}
