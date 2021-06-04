using System;

namespace ders1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "ankara", "izmir", "şanlıurfa", "kayseri", "eskişehir", "bursa", "kahramanmaraş" };

            foreach (string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //ikinci örnek

            int toplam = 0;
            int[] sayilar = {1,5,8,4,0,34 };
            foreach (int top in sayilar)
            {
                toplam = toplam + top;
            }
            Console.WriteLine("toplam: {0}",toplam);
            Console.WriteLine();

            // üçüncü örnek


            int[] rakamlar = { 1, 4, 6, 3, 5, 8, 2, 9 };
            foreach (int sayi in rakamlar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
            Console.WriteLine();

            // dördüncü örnek
            int sonuc = 1;
            int[] degerler = { 1, 2, 3, 4, 5, 6 ,7};
            foreach (int a in degerler)
            {
                sonuc = sonuc * a;
            }
            Console.WriteLine(degerler.Length+" sayısının katöriyeli: "+sonuc);
            Console.Read();

        }
    }
}
