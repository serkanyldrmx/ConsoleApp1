namespace Gammer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            Sales sales = new Sales();
            Console.WriteLine("Oyunumuza Hoşgeldiniz");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Lütfen Adınızı Giriniz :");
            gamer.FirstName = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Soyadınızı Giriniz :");
            gamer.LastName = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Doğum Yılınızı Giriniz :");
            var BirthYear= Console.ReadLine();
            gamer.BirthYear = Int32.Parse(BirthYear);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("TC Giriniz :");
            var Tc = Console.ReadLine();
            gamer.IdentityNumber = Int32.Parse(Tc);
            Console.WriteLine("---------------------------------");

            System.Threading.Thread.Sleep(1000);
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();



            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("<-GTA->  <-Valorant->  <-LOL->  <-CS->");
            Console.WriteLine("Almak İstediğiniz Oyunu Giriniz :");
            sales.SalesName = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            SalesManager salesManager = new SalesManager(new SalesValidateManager());
            salesManager.add(gamer, sales);


            Console.WriteLine("Ekleme(Add): 1\nSilme(Delete): 2\nGüncelleme(Update): 3\nYapmak istediğiniz işlemi seçiniz :");
            string processControl=Console.ReadLine();

            switch (processControl)
            {
                case "1":
                    {
                        gamerManager.Add(gamer);
                        break;
                    }
                case "2":
                    {
                        gamerManager.Delete(gamer);
                        break;
                    } 
                case "3": 
                    {
                        gamerManager.Update(gamer);
                        break;
                    }
                default: Console.WriteLine("Hatalı Giriş"); break;
            }
        }
    }
}
