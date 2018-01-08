using System;
using System.Collections.Generic;
using System.Text;

namespace House.Model
{
    public class ReviewRatingModel
    {
        public int Id { get; set; }
        public string ReviewDate { get; set; }
        public string Reviewedby { get; set; }
        public string ReviewAuthor { get; set; }
        public decimal ReviewAverage { get; set; }
        public decimal Localknowledge { get; set; }
        public decimal ProcessExpertise { get; set; }
        public decimal Responsiveness { get; set; }
        public decimal NegotiationSkills { get; set; }
        public string ReviewContent { get; set; }
    }
}
