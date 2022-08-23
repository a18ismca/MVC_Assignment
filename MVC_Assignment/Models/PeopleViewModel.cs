namespace MVC_Assignment.Models
{
    public class PeopleViewModel
    {

        public List<Person> people= new List<Person>();
        
        public List<Person> GetPeople() {

            people.Add(new Person { Name = "Alisa", Place="Stockholm", PhoneNumber = 28356 });
            people.Add(new Person { Name = "Erik", Place="Göteborg", PhoneNumber = 67890 });
            people.Add(new Person { Name = "Ismet", Place="Malmö", PhoneNumber = 12345 });
            people.Add(new Person { Name = "Åsa", Place="Malmö", PhoneNumber = 54545 });
            people.Add(new Person { Name = "Jagvetinte", Place= "Göteborg", PhoneNumber = 54343 });
            people.Add(new Person { Name = "Hejpådig", Place = "Stockholm", PhoneNumber = 54242 } );

            return people;


        }

        public List<Person> GetPeopleWithSpecifiedResidence(string residence)
        {
            return people.Where(x => x.Place == residence).ToList();
        }
    }
}
// +46704444817 Hur ser du på ditt framtida arbetsliv? 