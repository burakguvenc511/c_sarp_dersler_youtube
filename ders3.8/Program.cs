using System;

namespace ders3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            ucak UCAK = new ucak();
            UCAK.Marka = "thy";
            UCAK.Kalkis = "kahramanmaraş havalimanı";
            UCAK.Varis = "sabiha gökcen havalimanı";
            UCAK.Ad = "BURAK";
            UCAK.SoyAd = "güvenç";
            UCAK.Yas = 20;
            UCAK.Cinsiyet = "erkek";

            Console.WriteLine("uçak markası: "+UCAK.Marka);
            Console.WriteLine("ucak kalkış noktası: "+UCAK.Kalkis);
            Console.WriteLine("ucak varış noktası: "+UCAK.Varis);
            Console.WriteLine("yolcu adı: "+UCAK.Ad);
            Console.WriteLine("yolcu soyadı: "+UCAK.SoyAd);
            Console.WriteLine("yolcu yaşı: "+UCAK.Yas);
            Console.WriteLine("yolcu cinsiyeti: "+UCAK.Cinsiyet);

        }
    }
}
