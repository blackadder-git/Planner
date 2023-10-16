using SacramentPlanner.Models;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Topic")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Name { get; set; }


        [Required]
        [Display(Name = "Thought, Quote or Scripture")]
        public string? Quote { get; set; }
    }
}
