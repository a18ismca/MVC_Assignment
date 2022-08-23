// CreatePersonViewModel – Use to prevent overposting and to use data
// annotations to validate inputs when creating new person.


using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment.Models
{
    public class CreatePersonViewModel
    {
        PeopleViewModel pmv = new PeopleViewModel();
        
       

        public void AddPerson(List<Person> listOfPeople, string name)
        {
            listOfPeople.Add(new Person { Name = name });
            
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Residence")]
        public string Place { get; set; }

        
    }
}
