using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Interfaces
{
    interface ICampaign
    {
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal Discount { get; set; }
    }
}
