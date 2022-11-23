
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
        public List<Language> Languages { get; set; } = new List<Language>();
    }
}
