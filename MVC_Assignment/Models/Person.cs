using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.Models
{
    public class Person
    {
        [Range(0, 1000)]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone number")]
        [Required]
        public int PhoneNumber { get; set; }
        [Display(Name = "Residence")]
        [Required]
        public string City { get; set; }
    }
}
