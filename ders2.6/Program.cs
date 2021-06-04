using System;

namespace ders2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("satır için sayı girin: ");
            satir = Convert.ToInt16(Console.ReadLine());
            Console.Write("satır için sayı girin: ");
            sutun = Convert.ToInt16(Console.ReadLine());
            int[,] arr = new int[satir, sutun];
            Console.WriteLine();
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("matrisin {0} x {1} değeri girin: ",i+1,j+1);
                    arr[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(" {0} ",arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < sutun; i++)
            {
                for (int j = 0; j < satir ; j++)
                {
                    Console.Write(" {0} ", arr[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(" {0} ",arr[i,j]*5);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //ödev

            int carp;
            Console.Write("dizinin çarpılmasını istediğiniz katsayıyı girin: ");
            carp = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(" {0} ", arr[i, j] * carp);
                }
                Console.WriteLine();
            }
            Console.Read();

        
            //ikinci örnek

            // determinant
            int a, b, c, d, sonuc;
            Console.Write("a değeri girin: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b değeri girin: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c değeri girin: ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("d değeri girin: ");
            d = Convert.ToInt16(Console.ReadLine());
            sonuc =Math.Abs((a * d) - (b * c));             //math.abs kütüphanesi sayıyı mutlak değer içine alır.
            Console.WriteLine("\ndeterminant: "+sonuc);
            Console.Read();
        }
    }
}
