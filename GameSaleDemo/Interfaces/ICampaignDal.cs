using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Interfaces
{
    interface ICampaignDal
    {
        void Add(Campaign campaign);
        void Update();
        void Delete();
        void List();
    }
}
