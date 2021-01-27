using System;
using System.Threading.Channels;
using GameSaleDemo.Entities;
using GameSaleDemo.Interfaces;
using GameSaleDemo.Managers;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            MenuManager menuManager = new MenuManager();
            menuManager.MainMenu();

        }
    }
}
