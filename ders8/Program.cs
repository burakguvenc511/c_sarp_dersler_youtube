using System;

namespace ders8
{
    class Program
    {
        static void Main(string[] args)
        {
            
               string mevsim;
               Console.Write("mevsim adı giriniz:");
               mevsim = Console.ReadLine();

               if (mevsim == "kış")
               {
                   Console.WriteLine("----- kış mevsimi ayları -----");
                   Console.WriteLine("| aralık --- ocak --- şubat |");
               }
               else if (mevsim == "ilkbahar")
               {
                   Console.WriteLine("----- ilk bahar ayları -----");
                   Console.WriteLine("| mart --- nisan --- mayıs |");
               }
               else if (mevsim == "yaz")
               {
                   Console.WriteLine("----- yaz mevsimi ayları -----");
                   Console.WriteLine("| haziran --- temmuz --- ağustos |");
               }
               else if (mevsim == "sonbahar")
               {
                   Console.WriteLine("----- sonbahar mevsimi ayları -----");
                   Console.WriteLine("| eylül --- ekim --- kasım |");
               }
               else
               {
                   Console.WriteLine("hatalı mevsim girişi: ");
               }

               Console.Read();
           
            // ikinci örnek

            
            double x,indirim, odeme;

            Console.WriteLine("___VELİ KİTAPEVİ___");
            Console.WriteLine("kampanyalar: ");
            Console.WriteLine("1) 50-100 tl arası alışverişlerde %10 indirim");
            Console.WriteLine("2) 100-150 tl arası alışverişlerde %15 indirim");
            Console.WriteLine("3) 150-200 tl arası alışverişlerde %20 indirim");
            Console.WriteLine("4) 200 tl ve fazlası alışverişlerde %25 indirim");
            Console.WriteLine();
            Console.Write("fiyat giriniz: ");
            x = Convert.ToDouble(Console.ReadLine());
            if(x>=50 && x<100)
            {
                indirim = (x * 10) / 100;
                odeme = x - indirim;
                Console.WriteLine("kazandığınız indirim: "+ indirim);
                Console.WriteLine("yapılacak ödeme tutarı: "+odeme);
            }
            else if(x>=100 && x<150)
            {
                indirim = (x * 15) / 100;
                odeme = x - indirim;
                Console.WriteLine("kazandığınız indirim: " + indirim);
                Console.WriteLine("yapılacak ödeme tutarı: " + odeme);
            }
            else if(x>=150 && x<200)
            {
                indirim = (x * 20) / 100;
                odeme = x - indirim;
                Console.WriteLine("kazandığınız indirim: " + indirim);
                Console.WriteLine("yapılacak ödeme tutarı: " + odeme);
            }
            else if (x >= 200)
            {
                indirim = (x * 25) / 100;
                odeme = x - indirim;
                Console.WriteLine("kazandığınız indirim: " + indirim);
                Console.WriteLine("yapılacak ödeme tutarı: " + odeme);
            }
            Console.ReadLine();

        }
    }
}
