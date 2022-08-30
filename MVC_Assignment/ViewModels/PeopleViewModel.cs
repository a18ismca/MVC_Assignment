using Microsoft.EntityFrameworkCore;
using MVC_Assignment.Models;


namespace MVC_Assignment.ViewModels
{
    public class PeopleViewModel
    {
        public CreatePersonViewModel NewPerson { get; set; }

        
        public List<Person> People = new List<Person>();

        // use both new and existing data in the constructor below
        public PeopleViewModel()
        {
            NewPerson = new CreatePersonViewModel();
            GetPeople();
        }

        // return a list of people that are added to the People list in the method below.
        public List<Person> GetPeople()
        {

            People.Add(new Person { Id = 1, Name = "Alisa", City = "Stockholm", PhoneNumber = 28356 });
            People.Add(new Person { Id = 2, Name = "Erik", City = "Göteborg", PhoneNumber = 67890 });
            People.Add(new Person { Id = 3, Name = "Ismet", City = "Malmö", PhoneNumber = 12345 });
            People.Add(new Person { Id = 4, Name = "Åsa", City = "Malmö", PhoneNumber = 54545 });
            People.Add(new Person { Id = 5, Name = "Jagvetinte", City = "Göteborg", PhoneNumber = 54343 });
            People.Add(new Person { Id = 6, Name = "Hejpådig", City = "Stockholm", PhoneNumber = 54242 });

            return People;


        }
    }
}
