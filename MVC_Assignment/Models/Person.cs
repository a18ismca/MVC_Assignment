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

        [Display(Name = "Phone number"), MinLength(5), MaxLength(5)]
        [Required]
        public int PhoneNumber { get; set; }

        [Display(Name = "Residence")]
        [Required]
        public string City { get; set; }
    }
}
