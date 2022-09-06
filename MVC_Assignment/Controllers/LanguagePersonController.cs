using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class LanguagePersonController : Controller
    {
        readonly ApplicationDbContext _context;

        public LanguagePersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddLanguageToPerson()
        {
            ViewBag.PersonSelect = new SelectList(_context.People, "Id", "Name");
            ViewBag.LanguageSelect = new SelectList(_context.Languages, "LanguageId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddLanguageToPerson(int person_input, int language_input)
        {
            var language = _context.Languages.FirstOrDefault(x => x.LanguageId == language_input);

            var person = _context.People.FirstOrDefault(x => x.Id == person_input);

            person.Languages.Add(language);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
