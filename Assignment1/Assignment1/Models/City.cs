using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
