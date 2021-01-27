using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Managers
{
   public class CampaignManager:ICampaignDal
    {
        private bool _kontrol = true;
        private string _choice;
        private List<Campaign> campaigns = new List<Campaign>() { };
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine();
            Console.WriteLine("Kampanya eklendi!");
            Console.WriteLine();
        }

        public void Update()
        {
            while (_kontrol == true)
            {

                Console.Write("Değişmek istediğiniz kullanıcının TC Nosunu giriniz: ");
                _choice = Console.ReadLine();

                if (campaigns.Count > 0)
                {
                    foreach (var xUser in campaigns)
                    {
                        if (xUser.CampaignId == _choice)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kampanyanın güncel adı soyadı: " + xUser.CampaignId + " " + xUser.CampaignName + " " + xUser.Discount);
                            Console.WriteLine();
                            Console.Write("Kampanya yeni adı: ");
                            string newCampaignName = Console.ReadLine();
                            Console.Write("Kampanya yeni indirim miktarı: ");
                            decimal newCampaignDiscount = Convert.ToDecimal(Console.ReadLine());

                            xUser.CampaignName = newCampaignName;
                            xUser.Discount = newCampaignDiscount;
                            Console.WriteLine();
                            Console.WriteLine("Kampanyanın adı ve soyadı başarı bir şekilde güncellendi!");
                            Console.WriteLine();
                            break;
                        }
                        if (xUser.CampaignId != _choice || campaigns.Count < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kamapanya bulunamadı veya hatalı kampanya ID!");
                            Console.WriteLine();
                        }


                    }
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Kampanya bulunamadı!");
                    Console.WriteLine();
                    break;
                }

                break;







            }
        }

        public void Delete()
        {
            while (_kontrol == true)
            {

                Console.Write("Silmek istediğiniz Kampanyanın ID'sini giriniz: ");
                _choice = Console.ReadLine();

                if (campaigns.Count > 0)
                {
                    foreach (var xUser in campaigns)
                    {
                        if (xUser.CampaignId == _choice)
                        {
                            campaigns.Remove(xUser);
                            Console.WriteLine();
                            Console.WriteLine("Kampanya başarılı bir şekilde silindi!");
                            Console.WriteLine();
                            break;
                        }
                        if (xUser.CampaignId != _choice || campaigns.Count < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kampanya kullanıcı bulunamadı!");
                            Console.WriteLine();
                        }


                    }
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Kampanya bulunamadı!");
                    Console.WriteLine();
                    break;
                }

                break;







            }
        }

        public void List()
        {
            if (campaigns.Count > 0)
            {
                int sayac = 1;
                foreach (var xUser in campaigns)
                {
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(sayac + ". Kampanya Numarası: " + xUser.CampaignId + " " + "\nKampanya Adı: " + xUser.CampaignName + " " + "\nİndirim Oranı: " + xUser.Discount);
                        Console.WriteLine("-------------------------");
                        sayac += 1;
                    }

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Kampanya bulunamadı!");
                Console.WriteLine();
            }

        }
    }
}
