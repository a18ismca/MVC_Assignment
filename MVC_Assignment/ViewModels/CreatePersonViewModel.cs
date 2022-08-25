// CreatePersonViewModel – Use to prevent overposting and to use data
// annotations to validate inputs when creating new person.


using MVC_Assignment.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        [Range(0, 1000)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Residence")]
        public string City { get; set; }


    }
}
