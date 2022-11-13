using Assignment1.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.models
{
    public class PersonModel
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }
    }
}
