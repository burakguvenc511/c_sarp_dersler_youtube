using System;

namespace ders2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] say1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] say2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] toplam = new int[3, 3];
            Console.WriteLine("--- matrislerde toplama ---\n\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    toplam[i, j] = say1[i, j] + say2[i, j];
                    Console.Write(" {0} ",toplam[i,j]);
                }
                Console.WriteLine();
            }
            Console.Read();

            
            //ödev 
            Console.WriteLine();

            int[,] s1 = { { 1, 2, 3, 4},{ 4, 5, 6, 7} };
            int[,] s2 = { { 9, 8, 7, 6},{ 6, 5, 4, 3} };
            int[,] top = new int[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    top[i,j] = s1[i, j] + s2[i, j];
                    Console.Write(" {0} ", top[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
