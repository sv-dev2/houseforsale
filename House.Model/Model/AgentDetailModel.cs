using System;
using System.Collections.Generic;
using System.Text;

namespace House.Model
{
    public class AgentDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AgentDetail { get; set; }
        public string Brokerage { get; set; }
        public string Specialties { get; set; }
        public string LicenseNumber { get; set; }
        public string Picture { get; set; }
        public decimal AverageRating { get; set; }
        public int ReviewCount { get; set; }
        public decimal Localknowledge { get; set; }
        public decimal ProcessExpertise { get; set; }
        public decimal Responsiveness { get; set; }
        public decimal NegotiationSkills { get; set; }
    }
}
