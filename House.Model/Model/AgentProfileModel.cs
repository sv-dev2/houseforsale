using System;
using System.Collections.Generic;
using System.Text;

namespace House.Model
{
    public class AgentProfileModel
    {
        public List<ActiveListingsModel> ActiveListing { get; set; }
        public List<PastSalesModel> PastSales { get; set; }
        public AgentDetailModel AgentDetail { get; set; }
        public List<ReviewRatingModel> ReviewRating { get; set; }
    } 
}
