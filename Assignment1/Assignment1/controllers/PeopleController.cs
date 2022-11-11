using Assignment1.models;
using Assignment1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            if (PersonDetailViewModel.listOfPeople.Count == 0)
                PersonDetailViewModel.GenaratePeople();

            PersonDetailViewModel vm = new PersonDetailViewModel();

            vm.tempList = PersonDetailViewModel.listOfPeople;

            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(string searchString)
        {
            if (PersonDetailViewModel.listOfPeople.Count == 0)
                PersonDetailViewModel.GenaratePeople();

            PersonDetailViewModel vm = new PersonDetailViewModel();

            vm.tempList = PersonDetailViewModel.listOfPeople;

            if (!String.IsNullOrEmpty(searchString))
            {
                return View(vm.tempList.Where(s => s.Name.Contains(searchString)));
            }
            else
            {
                return View(vm.tempList.Where(s => s.City.Contains(searchString)));
            }


            //return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel person)
        {
            person.Id = Guid.NewGuid().ToString();
            if (person != null && ModelState.IsValid)
            {
                PersonDetailViewModel.listOfPeople.Add(person);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var personToDelete = PersonDetailViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if (personToDelete != null)
            {
                PersonDetailViewModel.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }
    }
}
