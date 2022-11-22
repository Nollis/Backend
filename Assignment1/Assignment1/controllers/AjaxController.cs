using Assignment1.Models;
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
            Person person = PeopleViewModel.listOfPeople.FirstOrDefault(x=>x.PersonId == id);

            return PartialView("_personPartial", person);
        }

        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            Person personToDelete = PeopleViewModel.listOfPeople.FirstOrDefault(x => x.PersonId == id);

            if (personToDelete != null)
            {
                PeopleViewModel.listOfPeople.Remove(personToDelete);
            }

            return PartialView("_personPartial", personToDelete);
        }

        public IActionResult GetPeople()
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
                PeopleViewModel.GenaratePeople();

            PeopleViewModel vm = new PeopleViewModel();

            vm.tempList = PeopleViewModel.listOfPeople;

            return PartialView("_allPeoplePartial", vm);
        }
    }
}
