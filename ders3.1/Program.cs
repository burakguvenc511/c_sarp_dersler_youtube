using System;

namespace ders3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("baklava dilim sayısı girin: ");
            int sayi,sayi2;
            sayi = Convert.ToInt16(Console.ReadLine());
            sayi2 = sayi;
            for (int i = 0; i < sayi/2+1; i++)
            {
                for (int j = 0; j < sayi2/2+1; j++)
                {
                    Console.Write(" ");
                }
                sayi2=sayi2-2; 
                for (int x = 0; x < i*2-1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            sayi2 = sayi;
            for (int i = sayi / 2 + 1; i > 0; i--)
            {
                for (int j = sayi2 / 2 + 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < i*2-1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }


        }
    }
}
