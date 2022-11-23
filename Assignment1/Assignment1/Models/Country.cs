using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<City> Cities { get; set; } = new List<City>();
        
    }
}
