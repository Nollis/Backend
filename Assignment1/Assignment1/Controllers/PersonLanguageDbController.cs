using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class PersonLanguageDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public PersonLanguageDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string personid)
        {
            var person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == personid);

            ViewBag.Name = person.Name;
            ViewBag.PersonId = person.Id;

            return View(person.Languages);
        }

        public IActionResult AddPersonToLanguage()
        {
            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            ViewBag.Languages = new SelectList(_context.Languages, "Id", "LanguageName");
            return View();
        }

        [HttpPost]
        public IActionResult AddPersonToLanguage(int languageid, string personid)
        {
            var person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == personid);
            var language = _context.Languages.Find(languageid);

            if (!person.Languages.Any(c => c.Id == language.Id))
            {
                person.Languages.Add(language);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.People, "Id", "Name");
                ViewBag.Languages = new SelectList(_context.Languages.Where(x => x.Id != languageid), "Id", "LanguageName");
                ViewBag.Message = $"That person already have a language with Id: {language.Id}!";
                return View();
            }


            return RedirectToAction("Index", new { personid = personid });
        }
        public IActionResult RemoveLanguageFromPerson(int languageid, string personid)
        {
            var person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == personid);
            var languageToRemove = _context.Languages.Find(languageid);

            person.Languages.Remove(languageToRemove);
            _context.SaveChanges();
            return RedirectToAction("Index", new { personid = personid });

        }
    }
}
