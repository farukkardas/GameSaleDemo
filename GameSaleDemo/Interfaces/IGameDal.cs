using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Interfaces
{
    interface IGameDal
    {
        void Add(Game game);
        void Update();
        void List();
        void Delete();
        void BuyGame();

    }
}
