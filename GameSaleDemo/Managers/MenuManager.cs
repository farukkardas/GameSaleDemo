using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameSaleDemo.Entities;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Managers
{
    public class MenuManager:IMenuService
    {
        public void MainMenu()
        {
            bool _kontrol = true;
            string choice = null;
            IUserDal userDal = new UserManager();
            IGameDal gameDal = new GameManager();
            ICampaignDal campaignDal = new CampaignManager();
            IVerificationService verificationService = new ValidationManager();
           
            
            

            Console.WriteLine("-------- OYUN SATIŞ PLATFORMUNA HOŞGELDİNİZ --------");



            while (_kontrol == true)
            {
                Console.WriteLine();
                Console.WriteLine("## Oyun İşlemleri ##        ## Hesap İşlemleri ##             ## Kampanya İşlemleri ##");
                Console.WriteLine();
                Console.WriteLine("1.Oyun Ekle                   6.Oyuncu Ekle                      A.Kampanya Ekle                   ");
                Console.WriteLine("2.Oyun Sil                    7.Oyuncu Sil                       B.Kampanya Sil                       ");
                Console.WriteLine("3.Oyun Listele                8.Oyuncu Listele                   C.Kampanya Listele                    ");
                Console.WriteLine("4.Oyun Güncele                9.Oyuncu Güncelle                  D.Kampanya Güncelle                   ");
                Console.WriteLine("5.Oyun Satın Al");
                Console.WriteLine();
                Console.Write("## Seçiminiz: ");
                choice = Console.ReadLine();

                if (choice == "6")
                {
                    Console.WriteLine();
                    Console.Write("İsim: ");
                    string name = Console.ReadLine();
                    Console.Write("Soyisim: ");
                    string lastName = Console.ReadLine();
                    Console.Write("TC NO: ");
                    string tcNo = Console.ReadLine();
                    Console.Write("Doğum Yılı: ");
                    int birthYear = Int32.Parse(Console.ReadLine());
                    Console.Write("Kullanıcı Bakiyesi: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    
                    

                    userDal.Add(new User() { Name = name, LastName = lastName, TcNo = tcNo, BirthYear = birthYear, Balance = balance });

                    verificationService.Validation();



                }
                else if (choice == "7")
                {
                    userDal.Delete();
                }

                else if (choice == "8")
                {
                    userDal.List();
                }

                else if (choice == "9")
                {
                    userDal.Update();
                }

                else if (choice == "1")
                {
                    Console.Write("Oyunun ID'si (Sayısal): ");
                    string gameId = Console.ReadLine();     
                    Console.Write("Oyunun Adı: ");
                    string gameName = Console.ReadLine();
                    Console.Write("Oyunun fiyatı: ");
                    decimal gamePrice = Convert.ToDecimal(Console.ReadLine());
                    gameDal.Add(new Game()  {GameId = gameId ,GameName = gameName,Price = gamePrice});
                }
                
                else if (choice == "2")
                {
                    gameDal.Delete();
                }
                else if (choice == "3")
                {
                    gameDal.List();
                }
                else if (choice == "4")
                {
                    gameDal.Update();
                }
                else if (choice == "5")
                {
                
                    gameDal.BuyGame();
                    
                }

                else if (choice == "A")
                {
                    Console.Write("Kampanya ID (Sayısal): ");
                    string newCampaignId = Console.ReadLine();
                    Console.Write("Kampanya Adı: ");
                    string newCampaignName = Console.ReadLine();
                    Console.Write("İndirim miktarı: ");
                    decimal newDiscount = Convert.ToDecimal(Console.ReadLine());

                    campaignDal.Add(new Campaign() {CampaignId = newCampaignId,CampaignName = newCampaignName,Discount = newDiscount});
                }
                else if (choice == "B")
                {
                    campaignDal.Delete();
                }
                else if (choice == "C")
                {
                    campaignDal.List();
                }
                else if (choice == "D")
                {
                    campaignDal.Update();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Hatalı seçim!!");
                    Console.WriteLine();
                }

                //////////////////////////////////////////////

               


            }
        }
    }
}
