using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;
using NuGet.Protocol;

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


            var people = _context.People;

            


            return people;

        }

    

        
        [HttpDelete("delit/{id}")]
        public async Task<ActionResult> DeletePerson(int id)
        {
            var person = _context.People.FirstOrDefault(x => x.Id == id);


            _context.People.Remove(person);

            await _context.SaveChangesAsync();


            return Ok(person);
        }

        


        /*  Where, OrderBy(Descending), ThenBy(Descending), Skip or Take operations */



        [HttpGet("languages")]
        public IEnumerable<Language> GetLanguages()
        {
            var data = _context.Languages.Include(x => x.People);

            return data;

        }

        [HttpGet("cities")]
        public IEnumerable<City> GetCities()
        {
            var data = _context.Cities;

            return data;
        }

        [HttpGet("countries")]
        public IEnumerable<Country> GetCountries()
        {

            var data = _context.Countries;

            return data;
        }

        [HttpGet("{countryId}/cities")]
        public IEnumerable<City> GetCitiesInCountry(int countryId)
            {
            var cities = _context.Cities.Where(x => x.CountryId == countryId);
            return cities; 
            }

        [HttpGet("personaldetails/{id}")]
        public IEnumerable<Person> GetPersonDetails(int id)
        {
            var person = _context.People.Where(x => x.Id == id).Include(x => x.Languages).Include(x => x.City).ThenInclude(x => x.Country);


            return person;

        }

        [HttpPost("addperson")]
        public Person AddPerson(Person person)
        {

            person = new Person();


            ModelState.Remove("City");
            ModelState.Remove("Languages");

            if(ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
            }

            return person;
        }
    }
}


