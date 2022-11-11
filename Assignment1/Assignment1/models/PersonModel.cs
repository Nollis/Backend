using System.ComponentModel.DataAnnotations;

namespace Assignment1.models
{
    public class PersonListModel
    {
        public string SearchText { get; set; }
        public List<PersonModel> PersonModelList { get; set; }
    }

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
