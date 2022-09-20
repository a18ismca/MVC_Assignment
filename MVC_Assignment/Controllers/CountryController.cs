using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class CountryController : Controller
    {

        readonly ApplicationDbContext _context;

        public CountryController(ApplicationDbContext context)
        {
            _context = context;
        }   

        public IActionResult Index()
        {
            var countries = _context.Countries;
            return View(countries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country c, string name_input)
        {
            c = new Country { Name = name_input };

            _context.Countries.Add(c);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {


            var country = _context.Countries.FirstOrDefault(x => x.CountryId == id);
            return View(country);

        }


        [HttpPost]
        public IActionResult Edit(Country c)
        {

            // ska jag ändra till cascade?
            ModelState.Remove("Id");

            _context.Countries.Update(c);

            /* SqlException: The UPDATE statement conflicted with the FOREIGN KEY constraint "FK_Cities_Countries_CountryId".The conflict occurred in database "MVC_Assignment", table "dbo.Countries", column 'CountryId'.
    The statement has been terminated. */


            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCountry(int id)
        {
            var country = _context.Countries.FirstOrDefault(x => x.CountryId == id);

            if (country != null)
            {
                _context.Countries.Remove(country);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");

        }
    }
}
