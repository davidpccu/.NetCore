using System.ComponentModel.DataAnnotations;

namespace StarterM.Models
{
    public class Employee
    {
        [Display(Name = "Employee Id")]
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

    }
}
