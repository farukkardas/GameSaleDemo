using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;
using GameSaleDemo.Entities;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Managers
{
    public class UserManager : IUserDal
    {
        private bool _kontrol = true;
        private string _choice;
        public static List<User> users = new List<User>() { };

        public List<User> getList()
        {
            return users;
        }

        public void Add(User user)
        {
            users.Add(user);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Delete()
        {

            while (_kontrol == true)
            {

                Console.Write("Silmek istediğiniz kullanıcının TC Nosunu giriniz: ");
                _choice = Console.ReadLine();

                if (users.Count > 0)
                {
                    foreach (var xUser in users)
                    {
                        if (xUser.TcNo == _choice)
                        {
                            users.Remove(xUser);
                            Console.WriteLine();
                            Console.WriteLine("Kullanıcı başarılı bir şekilde silindi!");
                            Console.WriteLine();
                            break;
                        }
                        if (xUser.TcNo != _choice || users.Count < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Hatalı TCNo veya kullanıcı bulunamadı!");
                            Console.WriteLine();
                        }


                    }
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Kullanıcı bulunamadı!");
                    Console.WriteLine();
                    break;
                }

                break;







            }

        }

   

        public void Update()
        {
            while (_kontrol == true)
            {

                Console.Write("Değişmek istediğiniz kullanıcının TC Nosunu giriniz: ");
                _choice = Console.ReadLine();

                if (users.Count > 0)
                {
                    foreach (var xUser in users)
                    {
                        if (xUser.TcNo == _choice)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kullanıcının güncel adı soyadı: " + xUser.Name + " " + xUser.LastName );
                            Console.WriteLine();
                            Console.Write("Kullanıcının yeni adı: ");
                            string newName = Console.ReadLine();
                            Console.Write("Kullanıcının yeni soyadı: ");
                            string lastName = Console.ReadLine();

                            xUser.Name = newName;
                            xUser.LastName = lastName;
                            Console.WriteLine();
                            Console.WriteLine("Kullanıcının adı ve soyadı başarı bir şekilde güncellendi!");
                            Console.WriteLine();
                            break;
                        }
                        if (xUser.TcNo != _choice || users.Count < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Hatalı TCNo veya kullanıcı bulunamadı!");
                            Console.WriteLine();
                        }


                    }
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Kullanıcı bulunamadı!");
                    Console.WriteLine();
                    break;
                }

                break;







            }
        }

        public void List()
        {


            if (users.Count > 0)
            {
                int sayac = 1;
                foreach (var xUser in users)
                {
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(sayac + ". Kullanıcı: " + "\nİsim: " + xUser.Name + " " + "\nSoyisim: " + xUser.LastName + " " + "\nBakiye: " + xUser.Balance);
                        Console.WriteLine("-------------------------");
                        sayac += 1;
                    }

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Kullanıcı bulunamadı!");
                Console.WriteLine();
            }

        }


    }
}
