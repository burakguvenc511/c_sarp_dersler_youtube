using System;

namespace ders3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            araba car = new araba();
            car.renk = "siyah";
            car.fiyat= 128000;
            car.model = "2005";
            car.vitesTuru = "automatic";
            car.plaka = "46 LR 240";
           // car.tekerKalite => private olduğu için ulaşılamıyor

            Console.WriteLine("araç rengi: "+ car.renk);
            Console.WriteLine("araç fiyatı: "+ car.fiyat);
            Console.WriteLine("araç modeli: "+car.model);
            Console.WriteLine("aracın vites türü: "+car.vitesTuru);
            Console.WriteLine("aracın plakası: "+car.plaka);

            Console.WriteLine("\n");

            car.renk = "beyaz";
            car.fiyat = 100000;
            car.model = "2016";
            car.vitesTuru = "manuel";
            car.plaka = "46 HZ 808";

            Console.WriteLine("araç rengi: " + car.renk);
            Console.WriteLine("araç fiyatı: " + car.fiyat);
            Console.WriteLine("araç modeli: " + car.model);
            Console.WriteLine("aracın vites türü: " + car.vitesTuru);
            Console.WriteLine("aracın plakası: " + car.plaka);
            Console.Read();
        }
    }
}