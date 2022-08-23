using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class DataController : Controller
    {
        PeopleViewModel dataTable = new PeopleViewModel();
        CreatePersonViewModel cpvm = new CreatePersonViewModel();

        public IActionResult DataView()
        {
            return View(dataTable.GetPeople());
        }

        [HttpPost]
        public IActionResult DataView(string residence_input)
        {
            return View(dataTable.GetPeopleWithSpecifiedResidence(residence_input));
        }


        public IActionResult AddNewPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPersonToList(string nejm)
        {
            cpvm.AddPerson(dataTable.people, nejm);
            return RedirectToAction("DataView");
        }
    }
}
