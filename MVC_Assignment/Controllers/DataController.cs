using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.ViewModels;
using MVC_Assignment.Models;
using MVC_Assignment.DbData;

namespace MVC_Assignment.Controllers
{
    public class DataController : Controller
    {
        

        readonly ApplicationDbContext _context;

        public DataController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Used to assign id's to newly created persons added to the list.

        //public static int incrementer = data.People.Count();

        public IActionResult Index()
        {
            var listOfPeople = _context.People.ToList();
            return View(listOfPeople);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person p)
        {
            

            if (ModelState.IsValid)
            {
                _context.People.Add(p);
             
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        
        [HttpPost]
        // Depending on the input, the persons that have the city and name attributes
        // will be shown when submitting the form.
        public IActionResult FilterPersons(string user_input)
        {
            var listOfPeople = _context.People.ToList();

            if (user_input == "")
            {
                return RedirectToAction("Index");
            }
            

                var filteredData = listOfPeople.Where(x => (x.City == user_input) 
                                                    || (x.Name == user_input)).ToList();


                listOfPeople = filteredData;


                if (listOfPeople.Count == 0)
                {
                    return View("Index");
                }
            
            

            return View("Index", listOfPeople);
        }

        /*

        
        
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

        */
       
    }
}
