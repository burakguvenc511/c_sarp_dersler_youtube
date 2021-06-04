using System;

namespace ders3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                //üst ve alt satır
                if (i == 0 || i==sayi-1)
                {
                    for (int l = 0; l < sayi; l++)
                    {
                        Console.Write("* ");
                    } 
                }
                //ortası boş olan kenarlar
                else
                {
                    Console.Write("*");
                    for (int k = 0; k < (sayi-1)*2-1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
