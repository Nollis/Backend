
using System.ComponentModel.DataAnnotations;

namespace Assignment1.models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }
    }
}
