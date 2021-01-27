using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Interfaces
{
    interface IUserDal
    {
        void Add(User user);
        void Delete();
        void Update();
        void List();

        List<User> getList();

    }
}
