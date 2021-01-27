using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Interfaces;

namespace GameSaleDemo.Managers
{
    class ValidationManager : IVerificationService

    {
        private IUserDal valiUserDal = new UserManager();
        public void Validation()
        {
            foreach (var valUser in valiUserDal.getList())
            {
                if (valUser.TcNo.Length < 11 || valUser.TcNo.Length > 11 || valUser.BirthYear <= 1900 || valUser.BirthYear >= 2021)
                {
                    Console.WriteLine("E Devlet doğrulaması sağlanamadı tekrar deneyiniz!");
                    valiUserDal.getList().Remove(valUser);
                    
                }

                else if (valUser.BirthYear > 1901 && valUser.BirthYear < 2021 && valUser.TcNo.Length == 11)
                {
                    Console.WriteLine("Kullanıcı başarılı bir şekilde oluşturuldu");
                }
                break;
            }
        }
    }
}
