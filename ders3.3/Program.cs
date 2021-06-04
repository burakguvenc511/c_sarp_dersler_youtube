using System;

namespace ders3._3
{
    class Program
    {
        private static void Bilgi(string bilgi)
        {
            Console.WriteLine(bilgi);
        }

        public static void toplama(int birinci,int ikinci)
        {
            int toplam = birinci + ikinci;
            Console.Write(toplam);

        }

        private static int islem(int s1,int s2)
        {
            int t = s1 + s2;
            return t;
        }

        //ödev

        private static int Kup(int sayi)
        {
            int kup = sayi * sayi * sayi;
            return kup;
        }

        static void Main(string[] args)
        {
            int a, b;
            string bilgi;
            Console.Write("metin girin: ");
            bilgi = Console.ReadLine();
            
            Console.Clear();
            
            Bilgi(bilgi);

            Console.Write("sayı girin: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("sayı girin: ");
            b = Convert.ToInt32(Console.ReadLine());

            toplama(a, b);

            Console.WriteLine("\n");

            Console.WriteLine("islem method toplam cevabı: {0}",islem(5,8));
            Console.WriteLine();
            Console.WriteLine("5 sayısının küpü: {0}",Kup(5));

            Console.Read();
        }
    }
}
