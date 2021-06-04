using System;

namespace ders1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int enB;
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. sayıyı girin: ",i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            enB = sayilar[0];
            for (int i = 1; i < 5; i++)
            {
                if (sayilar[i] > enB)
                {
                    enB = sayilar[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(enB);

            
            //ikinci ornek 


            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.Write("{0}. öğrencini adı: ",i+1);
                isim[i] = Console.ReadLine();
                
                Console.Write("{0}. öğrencini ilk sınav notu: ", i + 1);
                s1[i] = Convert.ToInt32(Console.ReadLine());
                    
                Console.Write("{0}. öğrencini ikinci sınav notu: ", i + 1);
                s2[i] = Convert.ToInt32(Console.ReadLine());
                ort[i] = (s1[0] + s2[i]) / 2;
            }
            Console.Clear();
            Console.WriteLine("   öğrenci adı   1.sınav   2.sınav   ortalama   ");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("   "+isim[i]+"        "+s1[i]+"         "+s2[i]+"         "+ort[i]);
            }
                
            Console.ReadLine();
        }
    }
}
