using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; } 
        public string CityName { get; set; }

        public List<Person> People { get; set; } = new List<Person>();

        public int CountryId { get; set; }  

        public Country Country { get; set; }

    }
}
