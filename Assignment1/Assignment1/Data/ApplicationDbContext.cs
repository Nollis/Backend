using Assignment1.models;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            var personId = Guid.NewGuid().ToString();

            modelbuilder.Entity<Person>().HasData(new Person { Id = personId, Name = "Niklas Bergh", Phone = "031-123456", City = "Göteborg" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Greger Puff", Phone = "031-666666", City = "Mölndal" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "The Dude", Phone = "0707985544", City = "Falsterbo" });

            modelbuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Sweden" });

            modelbuilder.Entity<City>().HasData(new City { Id = 1, Name = "Göteborg" });

            modelbuilder.Entity<Person>()
                .HasMany(p => p.Countrys)
                .WithMany(c => c.People)
                .UsingEntity(j => j.HasData(new { PeopleId = personId, CountrysId = 1 }));


        }
    }
}
