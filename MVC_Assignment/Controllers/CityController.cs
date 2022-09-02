using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.DbData;

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
            ViewBag.CountryOptions = null;
            return View();
        }
    }
}
