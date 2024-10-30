using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Work.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required(ErrorMessage ="Employee Name is Required")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Display Order is Required")]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
