using Assignment1.models;
using Assignment1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ajaxIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            PersonModel person = PersonDetailViewModel.listOfPeople.FirstOrDefault(x=>x.Id == id);

            return PartialView("_personPartial", person);
        }

        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            PersonModel personToDelete = PersonDetailViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);

            if (personToDelete != null)
            {
                PersonDetailViewModel.listOfPeople.Remove(personToDelete);
            }

            return PartialView("_personPartial", personToDelete);
        }

        public IActionResult GetPeople()
        {
            if (PersonDetailViewModel.listOfPeople.Count == 0)
                PersonDetailViewModel.GenaratePeople();

            PersonDetailViewModel vm = new PersonDetailViewModel();

            vm.tempList = PersonDetailViewModel.listOfPeople;

            return PartialView("_allPeoplePartial", vm);
        }
    }
}
