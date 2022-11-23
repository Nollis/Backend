using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class LanguageDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public LanguageDbController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Languages.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Language language)
        {
            if(ModelState.IsValid)
            {
                _context.Languages.Add(language);
                _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int languageid)
        {
            var languageToRemove = _context.Languages.Find(languageid);

            if(languageToRemove != null)
            {
                _context.Languages.Remove(languageToRemove);
                _context.SaveChanges(true);
            }
            return RedirectToAction("Index");
        }
    }
}
