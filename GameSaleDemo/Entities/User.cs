using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Entities
{
    public class User:IUser
    {
        public int Id { get; set; }
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string LastName  { get; set; }
        public string TcNo { get; set; }
        public decimal Balance { get; set; }
        
    }
}
