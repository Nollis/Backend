using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; } 
        public string LanguageName { get; set; }
        public List<Person> People { get; set; } = new List<Person>();
    }
}
