using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class CityController : Controller
    {
        readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cities = _context.Cities.Include(x => x.Country);
            return View(cities);
        }

        public IActionResult Create()
        {
            ViewBag.CountryOptions = new SelectList(_context.Countries, "CountryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(City c, string name_input, int countryid_input)
        {
            c = new City { Name = name_input, CountryId = countryid_input };

            _context.Cities.Add(c);

            _context.SaveChanges();


            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            var city = _context.Cities.FirstOrDefault(x => x.CityId == id);
            return View(city);

        }


        /*
        [HttpPost]
        public IActionResult Edit(City c)
        {

            // ska jag ändra till cascade?
            ModelState.Remove("Id");

            _context.Update(c);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }*/


        public IActionResult DeleteCity(int id)
        {
            var city = _context.Cities.FirstOrDefault(x => x.CityId == id);

            if (city != null)
            {
                _context.Cities.Remove(city);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        
    }
}
