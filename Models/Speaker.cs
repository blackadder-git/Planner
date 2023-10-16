using SacramentPlanner.Models;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Meeting")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public int Meeting { get; set; }
        [Required]

        [Display(Name = "Name")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Name { get; set; }
        [Required]

        [Display(Name = "Subject")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Subject { get; set; }
    }
}