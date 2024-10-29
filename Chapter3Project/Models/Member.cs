using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Chapter3Project.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Letters are allowed.")]
        [StringLength(15, ErrorMessage = "Please enter your first name in the 15 character limit.")]
        [Display(Name = "First Name")]
        [Column("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "Please enter your last name in the 20 character limit.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Letters are allowed.")]
        [Display(Name = "Last Name")]
        [Column("LastName")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Favorite Smiski")]
        public string SetName { get; set; } = string.Empty;
    }
}
