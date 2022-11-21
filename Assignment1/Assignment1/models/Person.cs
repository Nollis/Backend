
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        //public City City { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
