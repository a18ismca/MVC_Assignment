using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.Models
{
    public class Country
    {

        [Key]
        [Range(0, 1000)]
        public int CountryId { get; set; }

        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
