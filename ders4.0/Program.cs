using System;

namespace ders4._0
{
    class Program
    {
        //ref kullanılmazsa 
        public static int artir(  int sayi)
        {

            sayi=sayi+1;
            return sayi;
        }

        //ref kullanılırsa
        static void artir2(ref int sayi2)
        {
            sayi2++;
        }

        //out kulanılmazsa
            // out kullanılmadan mainde herhangi bir edeğişken atayıp gönderemzsin

        //out kullanılırsa
        static void artır3(out int sayi3)
        {
            sayi3 = 12;
            sayi3++;
        }


        static void Main(string[] args)
        {
            //ref olmayan satır kodu 

            int a = 9;
            Console.WriteLine("{0}",artir(a));

            // ref olan satır kodu 

            int b = 99;
            artir2(ref b);
            Console.WriteLine(b);

            //out olmayan satır kodu
                // out kullanılmadan mainde herhangi bir edeğişken atayıp gönderemzsin

            //out olan satır kodu

            int c;
            artır3(out c);
            Console.WriteLine(c);

            Console.Read();
        }
    }
}
