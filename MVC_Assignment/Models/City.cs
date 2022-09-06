using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.Models
{
    public class City
    {

        [Key]
        [Range(0, 1000)]
        public int CityId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }
        public List<Person> Inhabitants { get; set; } = new List<Person>();







    }
}
