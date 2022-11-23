using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class CountryLanguageDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public CountryLanguageDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int countryid)
        {
            var country = _context.Countries.Include(x => x.Languages).FirstOrDefault(x => x.CountryId == countryid);

            ViewBag.CountryName = country.CountryName;
            ViewBag.CountryId = country.CountryId;

            return View(country.Languages);
        }

        public IActionResult AddLanguageToCountry()
        {
            ViewBag.Country = new SelectList(_context.Countries, "CountryId", "CountryName");
            ViewBag.Language = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            return View();
        }

        [HttpPost]
        public IActionResult AddLanguageToCountry(int languageid, int countryid)
        {
            var country = _context.Countries.Include(x => x.Languages).FirstOrDefault(x => x.CountryId == countryid);
            var language = _context.Languages.Find(languageid);

            if (!country.Languages.Any(c => c.LanguageId == language.LanguageId))
            {
                country.Languages.Add(language);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Countries = new SelectList(_context.Countries, "CountryId", "CountryName");
                ViewBag.Languages = new SelectList(_context.Languages.Where(x => x.LanguageId != languageid), "LanguageId", "LanguageId");
                ViewBag.Message = $"Country already have a language with Id: {language.LanguageId}!";
                return View();
            }


            return RedirectToAction("Index", new { countryid = countryid });
        }
        public IActionResult RemoveLanguageFromCountry(int languageid, int countryid)
        {
            var country = _context.Countries.Include(x => x.Languages).FirstOrDefault(x => x.CountryId == countryid);
            var languageToRemove = _context.Languages.Find(languageid);

            country.Languages.Remove(languageToRemove);
            _context.SaveChanges();
            return RedirectToAction("Index", new { countryid = countryid });

        }
    }
}
