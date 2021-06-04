using System;

namespace ders4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int gs = 0, fb = 0, ts = 0, bjk = 0;
            int sayac = 1;
            int a, b, c, d;
            Console.WriteLine("lig turnuvasına hoşgeldiniz...");
            Console.WriteLine("------------------------------");
            Random rastgele = new Random();


            while (sayac < 4)
            {
                

                a = rastgele.Next(0, 6);    //gs
                b = rastgele.Next(0, 6);    //fb
                c = rastgele.Next(0, 6);    //tr
                d = rastgele.Next(0, 6);    //bjk
                Console.Read();
                Console.WriteLine("{0}. hafta maç sonuçları: ", sayac);
                Console.WriteLine("------------------------------\n");
                switch (sayac)
                {
                    case 1:
                        Console.WriteLine("galatasaray {0} - {1} fenerbahçe", a, b);
                        Console.WriteLine("trabzonspor {0} - {1} beşiktaş\n\n", c, d);
                        break;
                    case 2:
                        Console.WriteLine("galatasaray {0} - {1} trabzonspor", a, c);
                        Console.WriteLine("fenerbahçe  {0} - {1} beşiktaş\n\n", b, d);
                        break;
                    case 3:
                        Console.WriteLine("galatasaray {0} - {1} beşiktaş", a, b);
                        Console.WriteLine("trabzonspor {0} - {1} fenerbahçe\n\n", c, d);
                        break;
                }
                sayac++;
                Console.Read();
            }

            Console.Read();
        }
    }
}
