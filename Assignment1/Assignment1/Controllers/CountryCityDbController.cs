using Assignment1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class CountryCityDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public CountryCityDbController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var country = _context.Countries.Include(x => x.Cities).FirstOrDefault(x => x.CountryId == id);

            ViewBag.Name = country.CountryName;
            ViewBag.countryId = country.CountryId;

            return View(country.Cities);
        }
    }

}
