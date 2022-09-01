using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.ViewModels
{
    public class Country
    {

        [Key]
        public int CountryId { get; set; }

        public string Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
