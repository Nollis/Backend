using Assignment1.Controllers;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Assignment1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            var personId = Guid.NewGuid().ToString();

            modelbuilder.Entity<Person>().HasData(new Person { PersonId = personId, CityId = 1, Name = "Niklas Bergh", Phone = "031-123456" });
            modelbuilder.Entity<Person>().HasData(new Person { PersonId = Guid.NewGuid().ToString(), CityId = 2, Name = "Greger Puff", Phone = "031-666666" });
            modelbuilder.Entity<Person>().HasData(new Person { PersonId = Guid.NewGuid().ToString(), CityId = 2, Name = "The Dude", Phone = "0707985544" });

            modelbuilder.Entity<Country>().HasData(new Country { CountryId = 1, CountryName = "Sweden" });

            modelbuilder.Entity<Language>().HasData(new Language { LanguageId = 1, LanguageName = "Swedish" });

            modelbuilder.Entity<City>().HasData(new City { CityId = 1, CountryId = 1, CityName = "Göteborg" });
            modelbuilder.Entity<City>().HasData(new City { CityId = 2, CountryId = 1, CityName = "Stockholm" });

            modelbuilder.Entity<Country>()
                .HasMany(l => l.Languages)
                .WithMany(c => c.Countries)
                .UsingEntity(j => j.HasData(new { CountryId = 1, LanguageId = 1 }));

        }
    }
}
