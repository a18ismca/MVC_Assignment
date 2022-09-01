using System.ComponentModel.DataAnnotations;
using MVC_Assignment.Models;

namespace MVC_Assignment.ViewModels
{
    public class City
    {

        [Key]
        [Range(0, 1000)]
        public int CityId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }
        public List<Person> Inhabitants { get; set; }







    }
}
