using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using House.Model;
using House.Service;

namespace Houses.Forsale.Controllers
{
    public class HomeController : Controller
    {
        private IAgentProfileService _agentProfileService { get; set; }
        
        public HomeController(IAgentProfileService agentProfileService)
        {
            this._agentProfileService = agentProfileService;
        }
        public IActionResult Index()
        {
            var model = new AgentProfileModel();
            model.PastSales = _agentProfileService.GetPastSales();
            model.ActiveListing = _agentProfileService.GetActiveListing();
            model.AgentDetail = _agentProfileService.GetAgentDetail();
            model.ReviewRating = _agentProfileService.GetReviewRating();
            return View(model);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
