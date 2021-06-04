using System;

namespace ders4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi, sayi2, toplam,fark,carpim,bolum;
            Console.WriteLine("----- TOPLAMA -----");
            Console.WriteLine();
            Console.Write("1. sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            toplam = sayi + sayi2;
            fark = sayi - sayi2;
            carpim = sayi * sayi2;
            bolum = sayi / sayi2;
            Console.WriteLine("toplam: " + toplam);
            Console.WriteLine("fark: " + fark);
            Console.WriteLine("çarpım: " + carpim);
            Console.WriteLine("bölüm: " + bolum);
            
            Console.Read();
            
            //kare alan ornegi//
            int KareCevre, KareAlan,DCevre,DAlan;
            int KisaKenar, UzunKenar,KareKenar;
            Console.Write("kare kenarını girin: ");
            KareKenar = Convert.ToInt32(Console.ReadLine());
            KareCevre = KareKenar * 4;
            KareAlan = KareKenar * KareKenar;

            Console.WriteLine("kare alanı: "+KareAlan);
            Console.WriteLine("kare çevresi: "+KareCevre);

            Console.WriteLine();

            Console.Write("kısa kenar girin: ");
            KisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("uzun kenar girin: ");
            UzunKenar = Convert.ToInt32(Console.ReadLine());
            DAlan = KisaKenar * UzunKenar;
            DCevre = (KisaKenar * 2) + (UzunKenar * 2);
          
            Console.WriteLine();

            Console.WriteLine("dikdörtgen çevresi: "+DCevre);
            Console.WriteLine("dikdörtgen alanı: "+DAlan);
            Console.Read();
        }
    }
}
