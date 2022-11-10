using Assignment1.controllers;
using Assignment1.models;
using System.Net;
using System.Security.Policy;

namespace Assignment1.ViewModels
{
    public class PersonDetailViewModel
    {
        public static List<PersonModel> listOfPeople = new List<PersonModel>();

        public List<PersonModel> tempList = new List<PersonModel>();

        public PersonModel person { get; set; }

        public static void GenaratePeople()
        {
            listOfPeople.Add(new PersonModel { Id = Guid.NewGuid().ToString(), Name = "Niklas Bergh", Phone = "0702985046", City = "Göteborg"});
            listOfPeople.Add(new PersonModel { Id = Guid.NewGuid().ToString(), Name = "Egon Musk", Phone = "031998877", City = "Falun" });
            listOfPeople.Add(new PersonModel { Id = Guid.NewGuid().ToString(), Name = "Serker Grogg", Phone = "08445533", City = "Uppsala" });
        }
    }
}
