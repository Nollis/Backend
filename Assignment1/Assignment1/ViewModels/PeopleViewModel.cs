using Assignment1.Models;

namespace Assignment1.ViewModels
{
    public class PeopleViewModel
    {
        public static List<Person> listOfPeople = new List<Person>();

        public List<Person> tempList = new List<Person>();

        public static string searchString { get; set; }

        public CreatePersonViewModel CreatePersonViewModel { get; set; }

        public static void GenaratePeople()
        {
            //listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Niklas Bergh", Phone = "0702985046", City = "Göteborg" });
            //listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Egon Musk", Phone = "031998877", City = "Falun" });
            //listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Serker Grogg", Phone = "08445533", City = "Uppsala" });
        }
    }
}
