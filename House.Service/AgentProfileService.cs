using House.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Service
{
    public class AgentProfileService : IAgentProfileService
    {
        public List<PastSalesModel> GetPastSales()
        {
            var propertyList = new List<PastSalesModel>();
            var pastSales1 = new PastSalesModel
            {
                Id = 1,
                Address = "3247 Greystone Dr • Jamul, CA 91935",
                Price = "$900,000",
                Location = "Jamul, CA",
                PropertyDetail = "7 bed, 4 bath, 6,150 sqft",
                SoldDate = "09/12/2017",
                Picture = "../images/home5.jpg",
                Represented = "Seller",
            };
            var pastSales2 = new PastSalesModel
            {
                Id = 2,
                Address = "9951 Watergum Trl • Santee, CA 92071",
                Price = "$490,000",
                Location = "El Cajon, CA",
                PropertyDetail = "6 bed, 5.5 bath, 5,505 sqft",
                SoldDate = "07/21/2017",
                Picture = "../images/home4.jpg",
                Represented = " Buyer",
            };
            var pastSales3 = new PastSalesModel
            {
                Id = 3,
                Address = "627 Hawthorne Ave • El Cajon, CA 92020",
                Price = "$529,000",
                Location = "Santee, CA",
                PropertyDetail = "6 bed, 5.5 bath, 5,505 sqft",
                SoldDate = "09/11/2017",
                Picture = "../images/home12.jpg",
                Represented = " Buyer",
            };
            var pastSales4 = new PastSalesModel
            {
                Id = 4,
                Address = "9565 Janfred Way • La Mesa, CA 91942",
                Price = "$555,000",
                Location = "La Mesa, CA",
                PropertyDetail = "6 bed, 5.5 bath, 5,505 sqft",
                SoldDate = "07/11/2017",
                Picture = "../images/home6.jpg",
                Represented = " Buyer",
            };
            var pastSales5 = new PastSalesModel
            {
                Id = 5,
                Address = "5160 Alzeda Dr • La Mesa, CA 91941",
                Price = "$1,265,000",
                Location = "La Mesa, CA",
                PropertyDetail = "6 bed, 5.5 bath, 5,505 sqft",
                SoldDate = "07/07/2017",
                Picture = "../images/home7.jpg",
                Represented = " Seller",
            };
            propertyList.Add(pastSales1);
            propertyList.Add(pastSales2);
            propertyList.Add(pastSales3);
            propertyList.Add(pastSales4);
            propertyList.Add(pastSales5);
            return propertyList;
        }
        public List<ActiveListingsModel> GetActiveListing()
        {
            var activeList = new List<ActiveListingsModel>();
            var active1 = new ActiveListingsModel
            {
                Id = 1,
                Address = "472 Ponderosa Dr, Alpine",
                Picture = "../images/home1.jpg",
                Bathroom = " 3.0",
                Bedroom = " 4",
                Isfavorite = false,
                PhotoProperty = "12",
                Price = "$345,000",
                PriceChanges = "6,5",
                Squarefeet = "2,785",
                IsPriceUp = true,
                IsPriceDown = false,
            };
            var active2 = new ActiveListingsModel
            {
                Id = 2,
                Address = "472 Ponderosa Dr, Alpine",
                Picture = "../images/home8.jpg",
                Bathroom = "3.0",
                Bedroom = "4",
                Isfavorite = true,
                PhotoProperty = "12",
                Price = "$345,000",
                PriceChanges = "10",
                Squarefeet = "2,785",
                IsPriceUp = false,
                IsPriceDown = true
            };
            var active3 = new ActiveListingsModel
            {
                Id = 3,
                Address = "472 Ponderosa Dr, Alpine",
                Picture = "../images/home11.jpg",
                Bathroom = " 3.0",
                Bedroom = " 4",
                Isfavorite = false,
                PhotoProperty = "12",
                Price = "$345,000",
                PriceChanges = "",
                Squarefeet = "2,785",
                IsPriceDown = false,
                IsPriceUp = false
            };
            activeList.Add(active1);
            activeList.Add(active2);
            activeList.Add(active3);
            return activeList;
        }

        public AgentDetailModel GetAgentDetail()
        {
            return new AgentDetailModel
            {
                Id = 1,
                AgentDetail = @"<p>Being a full-service Realtor since 2007,
                I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and
                            processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to
                            exceed expectations and never forget that I am always accountable to my clients.</p>
                        <p>My objective is to establish relationships for life, not just for the current transaction. I enjoy assisting home buyers and sellers to get moved to a
                            better place, one that is exciting.</p>",
                Brokerage = "Berkshire Hathaway HomeServices Elite Real Estate",
                Specialties = "Property Management, Buyer’s Agent, Listing Agent…",
                LicenseNumber = "#5452129",
                AverageRating=4.5M,
                Localknowledge=4.5M,
                ProcessExpertise=4.2M,
                Responsiveness=5.0M,
                NegotiationSkills=4.1M,
                Picture= "../images/agent5.png",
                ReviewCount=16,
                Name= "Melissa Crosby",
            };
        }

        public List<ReviewRatingModel> GetReviewRating()
        {
            var ratings = new List<ReviewRatingModel>();
            var rating1 = new ReviewRatingModel
            {
                Id = 1,
                ReviewDate = " 09/24/2017",
                Reviewedby= "russroberts",
                ReviewAuthor= "Bought a home in 2017 in El Cajon, CA",
                ReviewAverage=4.5M,
                Localknowledge=4.5M,
                ProcessExpertise=4.2M,
                Responsiveness=5.0M,
                NegotiationSkills=4.1M,
                ReviewContent= @"Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market.
                        I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents.
                        I am very knowledgeable about lenders and their processes.I strive to exceed expectations and never forget that I am always accountable to my clients."

            };
            var rating2 = new ReviewRatingModel
            {
                Id = 2,
                ReviewDate = " 09/24/2017",
                Reviewedby = "russroberts",
                ReviewAuthor = "Bought a home in 2017 in El Cajon, CA",
                ReviewAverage = 4.5M,
                Localknowledge = 4.5M,
                ProcessExpertise = 4.2M,
                Responsiveness = 5.0M,
                NegotiationSkills = 4.1M,
                ReviewContent = @" Most important to me was communication and Mark saw that every question or concern of ours we met with full and complete information.
                        In most cases, Mark delivered information to us before we even had to ask.
                        I look forward to working with Mark in the future because I know that I can trust him to"

            };
            ratings.Add(rating1);
            ratings.Add(rating2);
            return ratings;
        }
    }
}
