using System;

namespace ders3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            insan Selam = new insan();
            Selam.selamver();
            Console.WriteLine("\n");

            turk Selam2 = new turk();
            Selam2.selamver();
            Console.WriteLine("\n");

            fransiz Selam3 = new fransiz();
            Selam3.selamver();
            Console.WriteLine("\n");

            ingiliz Selam4 = new ingiliz();
            Selam4.selamver();
            Console.Read();
        }
    }
}
