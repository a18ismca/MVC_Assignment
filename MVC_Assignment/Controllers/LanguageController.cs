using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class LanguageController : Controller
    {
        readonly ApplicationDbContext _context;

        public LanguageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var languages = _context.Languages;
            return View(languages);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Language l, string name_input)
        {
            l = new Language { Name = name_input };

            _context.Languages.Add(l);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteLanguage(int id)
        {
            var language = _context.Languages.FirstOrDefault(x => x.LanguageId == id);

            if (language != null)
            {
                _context.Languages.Remove(language);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");

        }
    }
}
