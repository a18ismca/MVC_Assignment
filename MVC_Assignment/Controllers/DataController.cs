using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.ViewModels;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class DataController : Controller
    {
        public static PeopleViewModel data = new PeopleViewModel();


        // Used to assign id's to newly created persons added to the list.

        public static int incrementer = data.People.Count();

        public IActionResult Index()
        {

            // Onödig kommentar
            return View(data);
        }

        [HttpPost]
        // Depending on the input, the persons that have the city and name attributes
        // will be shown when submitting the form.
        public IActionResult FilterPersonsOnCity(string user_input)
        {

            if (user_input == "")
            {
                return View("Index", data);
            }
            

                var filteredData = data.People.Where(x => (x.City == user_input) 
                                                    || (x.Name == user_input)).ToList();


                PeopleViewModel filteredModel = new PeopleViewModel();


                filteredModel.People = filteredData;

                if (filteredModel.People.Count == 0)
                {
                    return View("Index");
                }
            
            

            return View("Index", filteredModel);
        }

        
        public IActionResult AddPerson(PeopleViewModel m)
        {
            if (ModelState.IsValid)
            {

                data.People.Add(new Person()
                {
                    Id = ++incrementer,
                    Name = m.NewPerson.Name,
                    PhoneNumber = m.NewPerson.PhoneNumber,
                    City = m.NewPerson.City
                }
                );
                ViewBag.Statement = "The following person has been added: " + m.NewPerson.Name;
            }
            else {
              
                
                    ViewBag.Statement = "Please fill in the form above!";
                
            }

            return View("Index", data);
        }        
        public IActionResult DeletePerson(int id)
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
            
            return View("Index", data);
        }
       
    }
}
