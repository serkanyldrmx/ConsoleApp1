using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammer
{
    //MicroService
    internal class GamerManager : IGammerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            Console.WriteLine("Giriş Başarılı...");
            _userValidationService = userValidationService;

        }
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true) {

                Console.WriteLine("Kayıt Yapıldı");
            }
        }

        public void Delete(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Güncellendi");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Silindi");
            }
        }
    }
}
