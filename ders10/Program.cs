using System;

namespace ders10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int toplam=0;
            for (i = 0; i < 10; i++)
            {
                Console.Write("hello world:   ");
                Console.WriteLine(i);
                toplam = toplam + i;
            }
            Console.WriteLine();
            Console.WriteLine("toplam: "+toplam);
            Console.WriteLine();


            toplam = 0;
            for (i = 0; i < 10; i=i+2)
            {
                Console.Write("hello world:   ");
                Console.WriteLine(i);
                toplam = toplam + i;
            }
            Console.WriteLine();
            Console.WriteLine("toplam: " + toplam);
            Console.WriteLine();


            toplam = 0;
            for (i = 1; i < 10; i = i + 2)
            {
                Console.Write("hello world:   ");
                Console.WriteLine(i);
                toplam = toplam + i;
            }
            Console.WriteLine();
            Console.WriteLine("toplam: " + toplam);
            Console.WriteLine();
            Console.Read();
        }
    }

}
