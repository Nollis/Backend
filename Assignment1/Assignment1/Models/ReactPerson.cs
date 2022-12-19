using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public class ReactPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int? CityId { get; set; }

        public string City { get; set; }

        public int? CountryId { get; set; }

        public string Country { get; set; }

        public List<string> Languages { get; set; }
    }
}
