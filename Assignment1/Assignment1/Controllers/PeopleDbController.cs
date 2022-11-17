using Assignment1.Data;
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
    }
}
