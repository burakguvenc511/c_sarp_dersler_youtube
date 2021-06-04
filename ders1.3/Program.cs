using System;

namespace ders1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler giriş

            string[] harfler = { "a" ,"b","c","d","e","f"};
            Console.WriteLine(harfler[0]);  



            int[] sayilar = { 159, 156, 178, 352, 468 };
            Console.WriteLine(sayilar[4]);


            string[] sehirler = new string[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("sehir: ");
                sehirler[i] = Console.ReadLine();   
            }
            Console.WriteLine("----- sehirler ----");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

        }
    }
}
