using Assignment1.controllers;
using Assignment1.models;
using System.Net;
using System.Security.Policy;

namespace Assignment1.ViewModels
{
    public class PeopleViewModel
    {
        public static List<Person> listOfPeople = new List<Person>();

        public List<Person> tempList = new List<Person>();

        public string searchString { get; set; }

        public static List<Person> Search(string searchString, List<Person> listToFilter)
        {
            searchString = searchString.ToLower();
            var listToSend = listToFilter.FindAll(x => x.Name.ToLower().Contains(searchString) || x.City.ToLower().Contains(searchString));
            return listToSend;
        }

        public CreatePersonViewModel CreatePersonViewModel { get; set; }

        public static void GenaratePeople()
        {
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Niklas Bergh", Phone = "0702985046", City = "Göteborg"});
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Egon Musk", Phone = "031998877", City = "Falun" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Serker Grogg", Phone = "08445533", City = "Uppsala" });
        }
    }
}
