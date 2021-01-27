using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Entities
{
    class Campaign:ICampaign
    {
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal Discount { get; set; }
    }
}
