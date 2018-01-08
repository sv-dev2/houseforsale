using House.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Service
{
    public interface IAgentProfileService
    {
        List<PastSalesModel> GetPastSales();
        List<ActiveListingsModel> GetActiveListing();
        AgentDetailModel GetAgentDetail();
        List<ReviewRatingModel> GetReviewRating();
    }
}
