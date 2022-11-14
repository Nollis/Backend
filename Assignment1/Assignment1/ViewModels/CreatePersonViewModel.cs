using Assignment1.models;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.ViewModels
{
    public class CreatePersonViewModel
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }
    }
}
