using System;

namespace ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int deger1, deger2, bolum;
            deger1 = 20;
            deger2 = 48;
            bolum = (deger1 + deger2) / 2;
            Console.WriteLine(bolum);
            Console.Read();
            */
            string ad, soyad, numara;
            int not1, not2, not3, proje, ortalama;

            ad = "burak";
            soyad = "guvenc";
            numara = "123654789";

            not1 = 85;
            not2 = 80;
            not3 = 90;
            proje = 85;

            Console.WriteLine("----- ÖĞRENCİ BİLGİLERİ -----");
            Console.WriteLine();
            Console.WriteLine("ad: "+ ad);
            Console.WriteLine("soyad: "+soyad);
            Console.WriteLine("numara: "+numara);
            Console.WriteLine();
            Console.WriteLine("----- SINAV BİLGİLERİ -----");
            Console.WriteLine();
            Console.WriteLine("1. notunuz: " + not1);
            Console.WriteLine("2. notunuz: " + not2);
            Console.WriteLine("3. notunuz: " + not3);
            Console.WriteLine("proje notunuz: " + proje);
            Console.WriteLine();
            Console.WriteLine("----- ORTALAMA BİLGİSİ -----");
            ortalama = (not1 + not2 + not3 + proje) / 4;
            Console.WriteLine();
            Console.WriteLine("ortalamanız: "+ortalama);
        } 
    }
}
