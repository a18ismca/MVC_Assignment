using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;
using NuGet.Protocol;

namespace MVC_Assignment.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]

        // The context is used in order to store and change data from the front-end solution.

        public class ReactController : ControllerBase
        {
            readonly ApplicationDbContext _context;


        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // fetch all persons from the db

        [HttpGet("people")]
        public IEnumerable<Person> GetPeople()
        {
            var people = _context.People;

            return people;
        }

        [HttpGet("personaldetails/{id}")]
        public IEnumerable<Person> GetPersonDetails(int id)
        {
            var person = _context.People.Where(x => x.Id == id).Include(x => x.Languages).Include(x => x.City).ThenInclude(x => x.Country);

            return person;

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

        [HttpGet("languages")]
        public IEnumerable<Language> GetLanguages()
        {
            var data = _context.Languages.Include(x => x.People);

            return data;

        }

        // Set the person attributes to the person created in frontend.

        [HttpPost("addperson")]
        public Person AddPerson(Person person)
        {

            person = new Person { Name = person.Name, PhoneNumber = person.PhoneNumber, CityId = person.CityId };

            try
            {
                _context.People.Add(person);
                _context.SaveChanges();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

            return person;
        }

        // Is unused for this project.
        [HttpPut("editperson")]
        public async Task<ActionResult> EditPerson(Person person)
        {
           
            _context.People.Update(person);

            await _context.SaveChangesAsync();

            return Ok(person);
            
        }

        [HttpDelete("delit/{id}")]
        public async Task<ActionResult> DeletePerson(int id)
        {
            var person = _context.People.FirstOrDefault(x => x.Id == id);

            if (person != null)
            {
                _context.People.Remove(person);

                await _context.SaveChangesAsync();

            }

            return Ok(person);
        }
    }
}


