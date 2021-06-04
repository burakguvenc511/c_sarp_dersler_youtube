using System;

namespace ders2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            arr[0, 0] = 36;
            arr[0, 1] = 56;
            arr[1, 0] = 46;
            arr[1, 1] = 26;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();


            //ikinci örnek


            int[,] dizi = new int[2, 3];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[0, 2] = 30;
            dizi[1, 0] = 40;
            dizi[1, 1] = 50;
            dizi[1, 2] = 60;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ",dizi[i,j]);
                }
                Console.WriteLine();
            }
            Console.Read();


            //ödev
            Console.WriteLine();

            int[,] diz = new int[3, 2];
            diz[0, 0] = 10;
            diz[0, 1] = 20;
            diz[1, 0] = 30;
            diz[1, 1] = 40;
            diz[2, 0] = 50;
            diz[2, 1] = 60;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", diz[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
