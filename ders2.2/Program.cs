using System;

namespace ders2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool

            int sayi;
            Console.Write("sayıyı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayi > 0;
            bool durum2 = sayi > 10;
            Console.WriteLine("sayı pozitif mi ? "+durum1);
            Console.WriteLine("sayı büyük mü 10 dan ?"+durum2);

            
            //ikinci örnek
            int sifre;
            Console.WriteLine("şifreyi girin:");
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum = sifre == 12345;
            Console.WriteLine("şifre doğru mu ? "+durum);
            Console.Read();

        }
    }
}
