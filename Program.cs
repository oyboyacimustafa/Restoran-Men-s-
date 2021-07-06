using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Menüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int Secim;
            double Toplam = 0;
            do
            {
                Console.WriteLine("1 Adana = 12.75 TL");
                Console.WriteLine("2 Beyti = 22.50 TL");
                Console.WriteLine("3 Salata = 7.00 TL");
                Console.WriteLine("4 Çorba = 8.00 TL");
                Console.WriteLine("5 İçecek = 4.25 TL");
                Console.WriteLine("6 Çıkış");
                Console.WriteLine("Lütfen Seçim Yapın");
                Secim = int.Parse(Console.ReadLine());
                switch (Secim)
                {
                    case 1:
                        Toplam += 12.75;
                        Console.WriteLine("Şu Anki Hesap =" + Toplam);
                        break;
                    case 2:
                        Toplam += 22.50;
                        Console.WriteLine("Şu Anki Hesap =" + Toplam);
                        break;
                    case 3:
                        Toplam += 7.00;
                        Console.WriteLine("Şu Anki Hesap =" + Toplam);
                        break;
                    case 4:
                        Toplam += 8.00;
                        Console.WriteLine("Şu Anki Hesap =" + Toplam);
                        break;
                    case 5:
                        Toplam += 4.25;
                        Console.WriteLine("Şu Anki Hesap =" + Toplam);
                        break;
                    case 6:
                        Console.WriteLine("Hesabınız Tamamlandı");
                        break;
                    default:
                        Console.WriteLine("Lütfen 1-6 Arasında Seçim Yapınız.");
                        break;
                }

                
            

                 } while (Secim != 6);
                  Console.WriteLine("Toplam Hesap =" + Toplam);
            Console.ReadLine();
        }
    }
}
