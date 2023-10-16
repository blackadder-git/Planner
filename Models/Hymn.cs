using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Hymn
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Hymn")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Title { get; set; }

        [Required]
        //[RegularExpression(@"^[0-9""'\s-]*$")]
        public string? Page { get; set; }

        public bool Sacrament { get; set; }

    }
}
