using System;

namespace TechnicalAssessment.DataServices
{
    public class BlogPost
    {
        public string Title { get; set; }
        public string PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public string BodyText { get; set; }
    }
}
