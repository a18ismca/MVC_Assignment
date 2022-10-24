using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.Models
{

    public class Person
    {
        [Key]
        [Range(0, 1000)]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone number"), Range(00000, 99999)]
        [Required]
        public int PhoneNumber { get; set; }

        //[Display(Name = "Residence"), MaxLength(40)]
        
        public City? City { get; set; }
        [Required]
        public int CityId { get; set; }

        public List<Language> Languages { get; set; } = new List<Language>();
    }
}
