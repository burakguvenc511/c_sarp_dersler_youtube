using System;

namespace ders2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı girin: ");
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.Read(); 
            for (int i = sayi; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
