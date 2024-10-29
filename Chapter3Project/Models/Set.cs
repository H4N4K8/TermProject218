using System.ComponentModel.DataAnnotations;

namespace Chapter3Project.Models
{
    public class Set
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Letters are allowed.")]
        [StringLength(20, ErrorMessage = "That set name is too long!")]
        [Required(ErrorMessage = "Please enter set name.")]
        [Display(Name ="Set Name")]
        public string SetName { get; set; } = string.Empty;

        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Letters are allowed.")]
        [StringLength(30, ErrorMessage = "That pose name is too long!")]
        [Required(ErrorMessage = "Please enter pose for Smiski.")]
        [Display(Name = "Smiski Pose")]
        public string SmiskiType { get; set; } = string.Empty;

    }
}
