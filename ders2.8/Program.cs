using System;
 

namespace ders2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //zaman fonksiyonları
            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine(zaman);
            Console.Read();

            // örnek iki

            DateTime zaman2;
            zaman2 = DateTime.Now;
            int ay = zaman2.Month;
            int gun = zaman.Day;
            int yil = zaman.Year;
            int saat = zaman2.Hour;
            int dakika = zaman2.Minute;
            int saniye = zaman2.Second;
            int salise = zaman2.Millisecond;
            DayOfWeek haftaningunu = zaman.DayOfWeek;
            Console.WriteLine("günlerden {0}{1}, aylardan {2},  yıl {3}, saat {4}, dk {5} sn {6} salise {7}",gun,haftaningunu,ay,yil,saat,dakika,saniye,salise);
            Console.Read();

            //üçüncü örnek

            DateTime zaman3;
            zaman3 = DateTime.Now;
            Console.WriteLine("kısa tarih: {0:d}", zaman3);
            Console.WriteLine("uzun tarih: {0:D}",zaman3);
            Console.WriteLine("tam  tarih: {0:f}",zaman3);
            Console.WriteLine("tam 2tarih: {0:F}",zaman3);
            Console.WriteLine("sayısal tarih: {0:g}",zaman3);
            Console.WriteLine("sayısal 2tarih: {0:G}",zaman3);
            Console.WriteLine("ay tarih: {0:m}", zaman3);
            Console.WriteLine("biçim: {0:r}", zaman3);
            Console.WriteLine("biçim2: {0:s}", zaman3);
            Console.WriteLine("saat: {0:t}", zaman3);
            Console.WriteLine("saat: {0:T}", zaman3);
            Console.WriteLine("ay yıl: {0:Y}", zaman3);
            Console.Read();


        }
    }
}
