using System;

namespace ders1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int a;
            a = rastgele.Next(1, 11);           //yazılan küçük sayı dahildir randoma fakat buyuk dahil değildir
            Console.WriteLine(a);
            

            //ikinciğ örnek


            Random rast = new Random();
            int aa;
            int bb;
            aa = rast.Next(1, 11); 
            bb = rast.Next(1, 11);
            Console.WriteLine(aa+"   "+bb);
            


            //üçüncü örnek


            Random r = new Random();
            int sayi;
            sayi = r.Next(50);
            Console.WriteLine(sayi);


            //dördüncü örnek


            Random r1 = new Random();
            int s1;
            s1 = r1.Next();
            Console.WriteLine(s1);


            //beşinci örnek


            Console.WriteLine("----- ŞEHİR ATAM PROGRAMI -----");
            string[] sehir = { "adana", "bursa", "kahramanmaraş", "antalya", "edirne", "trabzon" };
            Random ran = new Random();
            int x;
            x = ran.Next(1,sehir.Length);
            Console.WriteLine(x);
            Console.WriteLine(sehir[x-1]);


            //alıştırma

            Console.WriteLine("----- SAYISAL LOTO ÇEKİLİŞ -----");
            Random loto = new Random();
            int x1, x2, x3, x4, x5, x6, x7;
            x1 = loto.Next(0, 10);
            x2 = loto.Next(0, 10);
            x3 = loto.Next(0, 10);
            x4 = loto.Next(0, 10);
            x5 = loto.Next(0, 10);
            x6 = loto.Next(0, 10);
            x7 = loto.Next(0, 10);
            Console.WriteLine();
            Console.WriteLine("----- SONUÇLAR -----");
            Console.WriteLine();
            Console.WriteLine(" "+x1 + " " + x2 + " " + x3 + " " + x4 + " " + x5 + " " + x6 + " " + x7);


            //ben yapıyom


            Random hebele = new Random();
            int q;
            int min, max;
            Console.Write("alt sınırı girin: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("üst değer girin: ");
            max = Convert.ToInt32(Console.ReadLine());
            q = hebele.Next(min, max+1);
            Console.WriteLine(q);
            Console.Read();
        }
    }
}
