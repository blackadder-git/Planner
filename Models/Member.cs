using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string? Name { get; set; }

        public bool Bishopric { get; set; }

    }
}
