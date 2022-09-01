using System.ComponentModel.DataAnnotations;
using MVC_Assignment.Models;

namespace MVC_Assignment.ViewModels
{
    public class City
    {

        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public List<Person> Inhabitants { get; set; }







    }
}
