using System.ComponentModel.DataAnnotations;


namespace MVC_Assignment.Models
{
    public class Language
    {
        [Key]
        [Range(0, 1000)]
        public int LanguageId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Person> People { get; set; } = new List<Person>();


    }
}
