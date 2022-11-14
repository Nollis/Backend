using Assignment1.models;
using Assignment1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
                PeopleViewModel.GenaratePeople();

            PeopleViewModel vm = new PeopleViewModel();

            vm.tempList = PeopleViewModel.listOfPeople;

            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(string searchString)
        {
            var AllPeople = from p in PeopleViewModel.listOfPeople
                            select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                AllPeople = AllPeople.Where(s => s.Name.Contains(searchString));
            }

            return View(AllPeople.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.Id = Guid.NewGuid().ToString();

            ModelState.Remove("Id");

            if(ModelState.IsValid)
            {
                PeopleViewModel.listOfPeople.Add(person);
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var personToDelete = PeopleViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if (personToDelete != null)
            {
                PeopleViewModel.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }
    }
}
