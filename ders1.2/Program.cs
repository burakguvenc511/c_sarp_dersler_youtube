using System;

namespace ders1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi;
            string cevap = "evet";
            while (cevap == "evet") {
                
                 Console.Write("sayi giriniz: ");
                 sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                if (sayi % 2 == 0)
                 {
                      Console.WriteLine("çift sayı girdiniz");
                    
                 }
                 else if (sayi % 2 == 1)
                 {
                     Console.WriteLine("tek sayı girdiniz");
                 }
            
                Console.WriteLine();
                 Console.Write("tekrar denemek ister misiniz? : ");
                 cevap = Console.ReadLine();
                Console.WriteLine();
                
            }
            
            //ikinci örnek 
            //faktöriyel

            int sayi1,sayi2, gecici = 1; ;
            Console.Write("faktöriyeli bulunmasını istediğiniz sayıyı girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = sayi1;
            while (sayi1 >= 1)
            {
                gecici = gecici * sayi1;

                sayi1--;
            }
            Console.WriteLine();
            Console.WriteLine("{0} faktöriyel {1} sayısına eşittir.",sayi2,gecici);
        }
    }
}
