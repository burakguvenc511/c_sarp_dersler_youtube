using System;

namespace ders1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 120; i++)
            {
                if (120 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            //ikinci örnek 
            //fibonacci

            int x=1, j=1,a;
            Console.WriteLine("--- fibonacci dizisi ---");
            Console.WriteLine(x);
            Console.WriteLine(j);
            for (int k = 0; k <10; k++)
            {
                a = x+j;
                x = j;
                j = a;
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
