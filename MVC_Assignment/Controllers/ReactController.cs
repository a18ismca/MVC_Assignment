using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;


    namespace MVC_Assignment.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ReactController : ControllerBase
        {
            readonly ApplicationDbContext _context;


            public ReactController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET /api/React/
            [HttpGet("people")]
            public IEnumerable<Person> GetPeople()
            {

                var data = _context.People;

                return data;

            }

            // GET /api/React/id
            [HttpGet("languages")]
            public IEnumerable<Language> GetLanguages()
            {
                var data = _context.Languages;

                return data;

            }

            [HttpGet("cities")]
            public IEnumerable<City> GetCities()
            {
                var data = _context.Cities;

                return data;

            }

            [HttpGet("people/{Id}")]
            public IEnumerable<Person> GetPersonDetails(int Id)
            {

                var data = _context.People.Where(x => x.Id == Id);

                return data;

            }





    }
}


