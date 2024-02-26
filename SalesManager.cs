using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammer
{
    internal class SalesManager : ISalesService
    {
        ISalesValidateService _salesValidateService;
        public SalesManager(ISalesValidateService salesValidateService)
        {
            _salesValidateService = salesValidateService;
        }
        public void add(Gamer gamer, Sales sales)
        {
            if(_salesValidateService.Validate(gamer, sales) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satış Ekleme Başarılı.");
            }
            else
            {
                Console.WriteLine("Satış Ekleme İşlemi başarısız.");
            }
        }

        public void delete(Gamer gamer, Sales sales)
        {
            if (_salesValidateService.Validate(gamer, sales) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satış Silme Başarılı.");
            }
            else
            {
                Console.WriteLine("Satış Silme İşlemi başarısız.");
            }
        }

        public void update(Gamer gamer, Sales sales)
        {
            if (_salesValidateService.Validate(gamer, sales) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satış Günceleme Başarılı.");
            }
            else
            {
                Console.WriteLine("Satış Güncelleme İşlemi başarısız.");
            }
        }

    }
}
