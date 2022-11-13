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
            var AllPeople = from p in PersonDetailViewModel.listOfPeople
                            select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                AllPeople = AllPeople.Where(s => s.Name.Contains(searchString));
            }

            return View(AllPeople);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel person)
        {
            person.Id = Guid.NewGuid().ToString();

            //var error = ModelState
            //    .Where(x => x.Value.Errors.Count > 0)
            //    .Select(x => new { x.Key, x.Value.Errors })
            //    .ToArray();

            if (person != null)
            {
                if(ModelState.IsValid)
                {
                    PersonDetailViewModel.listOfPeople.Add(person);
                }
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
