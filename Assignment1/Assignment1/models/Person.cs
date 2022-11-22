
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
