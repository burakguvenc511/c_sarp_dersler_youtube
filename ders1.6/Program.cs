using System;

namespace ders1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 28, -8, 9 };
            foreach (int sayi in sayilar)
            {
                    if(sayi>0 && sayi % 2 == 1)
                {
                    Console.WriteLine(sayi);
                }
            }


            //ikinci örnek


            int[] say = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("sayıları girin: ");
                say[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine();
            Array.Sort(say);        //burda array adı dizileri temsil eder. short ise otomatık sıralamadır. bunlar hazır komut olarak geçer.
            Array.Reverse(say);     //burda array adı dizileri temsil eder. reserrve ise sayıları tersten yazdırır. bunlar hazır komut olarak geçer.
            foreach (int sayım in say)
            {
                Console.WriteLine(sayım);
            }
            Console.WriteLine("dizinin boyutu: "+say.Length);

            
            //örnek üç sanırım ödev


            int[] s2 = new int[10] ;
            for (int a = 0; a < 5; a++)
            {
                Console.Write("sayı giriniz: ");
                s2[a] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(s2);
            Console.WriteLine("en buyuk eleman: "+s2[s2.Length-1]);
            Console.Read();
        }
    }
}
