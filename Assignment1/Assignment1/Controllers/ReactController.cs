﻿using Assignment1.Data;
using Assignment1.Models;
using Assignment1.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Versioning;
using System.Linq;
using System.Text.Json.Nodes;

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
            //people = _context.People.Include(p => p.City).ToList();
            people = _context.People.ToList();
            return people;
        }

        [HttpGet("{id}")]
        public async Task<ReactPerson> GetPersonDetails(string id)
        {
            Person person = await _context.People.Include(p => p.City).Include(l => l.Languages).FirstOrDefaultAsync(x => x.Id == id);
            City cityFromId = await _context.Cities.FirstOrDefaultAsync(c => c.CityId == person.CityId);

            List<string> languages = new();
            foreach (var language in person.Languages)
            {
                languages.Add(language.LanguageName);
            }

            ReactPerson reactPerson = new();

            if (cityFromId != null)
            {
                reactPerson.City = cityFromId.CityName;
                reactPerson.Country = _context.Countries.FirstOrDefault(x => x.CountryId == cityFromId.CountryId).CountryName;
                reactPerson.CountryId = cityFromId.CountryId;
            }

            reactPerson.Languages = languages;

            return reactPerson;
        }

        [HttpGet("countries")]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountry()
        {
            return await _context.Countries.ToListAsync();
        }

        [HttpDelete("{id}")]
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

        [HttpPost("create")]
        public IActionResult Create(JsonObject person)
        {
            string jsonPerson = person.ToString();

            Person personToCreate = JsonConvert.DeserializeObject<Person>(jsonPerson);

            if(personToCreate != null)
            {
                _context.People.Add(personToCreate);
                _context.SaveChanges();

                return StatusCode(200);
            }

            return StatusCode(404);
        }
    }
}
