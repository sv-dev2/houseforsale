using System;
using System.Collections.Generic;
using System.Text;

namespace House.Model
{
    public class ActiveListingsModel
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public string Price { get; set; }
        public string PriceChanges { get; set; }
        public string Address { get; set; }
        public string PhotoProperty { get; set; }
        public string Bedroom { get; set; }
        public string Bathroom { get; set; }
        public string Squarefeet { get; set; }
        public bool Isfavorite { get; set; }
        public bool IsPriceUp { get; set; }
        public bool IsPriceDown { get; set; }

    }
}
