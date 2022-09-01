using System.ComponentModel.DataAnnotations;
using MVC_Assignment.Models;

namespace MVC_Assignment.ViewModels
{
    public class City
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Inhabitants { get; set; }







    }
}
