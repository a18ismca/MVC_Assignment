using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.ViewModels;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class AjaxController : Controller
    {
        public static PeopleViewModel data = new PeopleViewModel();


        public IActionResult Index()
        {
               
            return View();
        }

        [HttpGet]
        public IActionResult FetchData()
        {
            return PartialView("_TableView", data);
        }

        [HttpPost]
        public IActionResult FetchData(int id)
        {
            var filteredData = data.People.Where(x => x.Id == id).ToList();


            PeopleViewModel filteredModel = new PeopleViewModel();


            filteredModel.People = filteredData;

            if (filteredModel.People.Count == 0)
            {
                return View("_TableView");
            }


            return View("_TableView", filteredModel);
            
          
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id != null)
            {
                try
                {
                    data.People.RemoveAt(id - 1);
                    ViewBag.Statement = $"A person with id {id} has been removed.";

                }
                catch (ArgumentOutOfRangeException aa)
                {
                    ViewBag.Statement = aa.Message;
                }
            }
            else
            {
                ViewBag.Statement = "Unable to remove person!";
            }

            
            return View("_TableView", data);
        }
    }
}
