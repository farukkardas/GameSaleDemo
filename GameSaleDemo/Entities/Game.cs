using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Entities
{
    class Game:IGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
    }
}
