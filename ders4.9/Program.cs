using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilinçsiz tür dönüşümü

            int a = 10;
            long b = a;
            Console.WriteLine(b);


            //bilinçli tür dönüşümü
            long c = 10;

            /*
                int d = c;        bu yazım tarzı yanlıştır
            */                    // convert işlemi unutulmamalıdır

            int d = Convert.ToInt32(c);     // doğru yazım budur

            Console.WriteLine(d);

            //boxing

            int sayi = 5;
            object sayi2 = sayi;
            Console.WriteLine(sayi2);

            //unboxing

            object sayi3 = 11;
            int sayi4 = Convert.ToInt32(sayi3); 
            Console.WriteLine(sayi4);

            //object bütün değer tiplern atası olarak kabul edilir hacmi çok geniştir.

            Console.Read();
        }
    }
}
