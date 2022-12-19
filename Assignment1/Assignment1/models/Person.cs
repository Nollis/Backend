
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
        public List<Language> Languages { get; set; } = new List<Language>();
    }
}
