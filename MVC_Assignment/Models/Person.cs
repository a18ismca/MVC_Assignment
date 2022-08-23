using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.Models
{
    public class Person
    {

        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Residence")]
        public string Place { get; set; }
    }
}
