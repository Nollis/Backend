using Assignment1.Controllers;
using Assignment1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Assignment1.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
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

            modelbuilder.Entity<Person>().HasData(new Person { Id = personId, CityId = 1, Name = "Niklas Bergh", Phone = "031-123456" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), CityId = 2, Name = "Greger Puff", Phone = "031-666666" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), CityId = 2, Name = "The Dude", Phone = "0707985544" });

            modelbuilder.Entity<Country>().HasData(new Country { CountryId = 1, CountryName = "Sweden" });

            modelbuilder.Entity<Language>().HasData(new Language { Id = 1, LanguageName = "Swedish" });

            modelbuilder.Entity<City>().HasData(new City { CityId = 1, CountryId = 1, CityName = "Göteborg" });
            modelbuilder.Entity<City>().HasData(new City { CityId = 2, CountryId = 1, CityName = "Stockholm" });

            modelbuilder.Entity<Person>()
                .HasMany(l => l.Languages)
                .WithMany(c => c.People)
                .UsingEntity(j => j.HasData(new { PeopleId = personId, LanguagesId = 1 }));

            string adminRoleId = Guid.NewGuid().ToString();
            string citizenId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelbuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
            modelbuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = citizenId,
                    Name = "Citizen",
                    NormalizedName = "CITIZEN"
                });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "boss@boss.com",
                NormalizedEmail = "BOSS@BOSS.COM",
                UserName = "boss@boss.com",
                NormalizedUserName = "BOSS@BOSS.COM",
                FirstName = "I_control",
                LastName = "Everything",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password!")
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId
            });

        }
    }
}
