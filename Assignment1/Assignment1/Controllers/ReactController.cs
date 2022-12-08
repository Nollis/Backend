using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people = _context.People.ToList();
            return people;
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var person = _context.People.Find(id);

            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();

                return StatusCode(200);
            }
            return StatusCode(404);
        }
    }
}
