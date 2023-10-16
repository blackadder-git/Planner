using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Congregation { get; set; }
        [DataType(DataType.Date)]

        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }
        [Required]
        public string? Conducting { get; set; }
        [Required]

        //[StringLength(60, MinimumLength = 3)]
        [Display(Name = "Invocation")]
        public string? OpeningPrayer { get; set; }

        [Required]
        //[StringLength(60, MinimumLength = 3)]
        [Display(Name = "Benediction")]
        public string? ClosingPrayer { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? OpeningHymn { get; set; }
        [Required]

        [Display(Name = "Sacrament Hymn")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? SacramentHymn { get; set; }
        [Display(Name = "Intermediate Hymn (Optional)")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? IntermediateHymn { get; set; }
        [Required]

        [Display(Name = "Closing Hymn")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? ClosingHymn { get; set; }

        [Display(Name = "Topic (Optional)")]
        public string? Topic { get; set; }
    }
}
