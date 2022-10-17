﻿using Microsoft.AspNetCore.Mvc;
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


       var people = _context.People.Include(x => x.City);

           

        

        //var person  = _context.People.Where(x=>x.Id == id).FirstOrDefault();    

        //var personCityId = _context.People.Select(p => p.CityId).FirstOrDefault();

                

        //var city = _context.Cities.Where(x => x.CityId == person.CityId).FirstOrDefault();

        //string cityName = city.Name;

            return people;

        }

       

    /*  Where, OrderBy(Descending), ThenBy(Descending), Skip or Take operations */



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
            

            var person = _context.People.Where(x => x.Id == id);

            return person;

        }// ej ::

        [HttpPost("people/add")]
        public Person AddPerson(string name, int phoneNumber, int cityId)
        {
            Person p = new Person { Name = name, PhoneNumber = phoneNumber, CityId = cityId };

            _context.People.Add(p);

            _context.SaveChanges();

            return p;
        }
    }
}


