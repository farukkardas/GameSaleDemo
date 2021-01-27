using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Managers
{
    public class GameManager:IGameDal
    {
        private IUserDal gameUserDal = new UserManager();
        
        string _choice;
        bool _kontrol = true;
         public List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine();
            Console.WriteLine("Oyun başarılı bir şekilde eklendi!");
            Console.WriteLine();
        }

        public void Update()
        {
        
            while (_kontrol == true)
            {

                Console.Write("Değişmek istediğiniz oyunun TC Nosunu giriniz: ");
                _choice = Console.ReadLine();

                if (games.Count > 0)
                {
                    foreach (var xUser in games)
                    {
                        if (xUser.GameId == _choice)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oyunun güncel adı: " + xUser.GameName);
                            Console.WriteLine();
                            Console.Write("Oyunun yeni adı: ");
                            string newGameName = Console.ReadLine();
                            Console.Write("Oyunun yeni fiyatı: ");
                            decimal newPrice = Convert.ToDecimal(Console.ReadLine());

                            xUser.Price = newPrice;
                            xUser.GameName = newGameName;
                  
                            Console.WriteLine();
                            Console.WriteLine("Oyunun bilgileri başarı bir şekilde güncellendi!");
                            Console.WriteLine();
                            break;
                        }
                        if (xUser.GameId != _choice || games.Count < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Hatalı ID veya oyun bulunamadı!");
                            Console.WriteLine();
                        }


                    }
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Oyun bulunamadı!");
                    Console.WriteLine();
                    break;
                }

                break;







            }
        }

        public void List()
        {
            if (games.Count > 0)
            {
                int sayac = 1;
                foreach (var xUser in games)
                {
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(sayac + ". Oyun: " + "\nİsim: " + xUser.GameName + "\nFiyat: " + xUser.Price);
                        Console.WriteLine("-------------------------");
                        sayac += 1;
                    }

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Oyun bulunamadı!");
                Console.WriteLine();
            }
        }

        public void Delete()
        {
            
            while (_kontrol == true)
            {

                Console.Write("Silmek istediğiniz oyunun ID'sini giriniz: ");
                _choice = Console.ReadLine();

                if (games.Count > 0)
                {
                    foreach (var xUser in games)
                    {
                        if (xUser.GameId == _choice)
                        {
                            games.Remove(xUser);
                            Console.WriteLine();
                            Console.WriteLine("Oyun başarılı bir şekilde silindi!");
                            Console.WriteLine();
                            break;
                        }
                        if (xUser.GameId != _choice || games.Count < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Hatalı ID veya oyun bulunamadı!");
                            Console.WriteLine();
                        }


                    }
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Oyun bulunamadı!");
                    Console.WriteLine();
                    break;
                }

                break;







            }
        }

        public void BuyGame()
        {
            foreach (var xUser in gameUserDal.getList())
            {
                Console.WriteLine(xUser.Name);
            }
        }
    }
}
