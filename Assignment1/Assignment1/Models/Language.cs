using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; } 
        public string LanguageName { get; set; }
        public List<Country> Countries { get; set; } = new List<Country>();
    }
}
