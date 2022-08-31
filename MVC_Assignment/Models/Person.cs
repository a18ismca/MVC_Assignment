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

        [Display(Name = "Phone number")]
        [Required]
        public int PhoneNumber { get; set; }

        [Display(Name = "Residence")]
        [Required]
        public string City { get; set; }
    }
}
