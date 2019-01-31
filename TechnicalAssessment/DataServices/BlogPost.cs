using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalAssessment.DataServices
{
    public class BlogPost
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PostedBy { get; set; }
        [Required]
        public DateTime PostedOn { get; set; }
        [Required]
        public string BodyText { get; set; }
    }
}
