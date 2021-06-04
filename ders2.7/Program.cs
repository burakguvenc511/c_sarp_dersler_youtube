using System;

namespace ders2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // matematik fonskiyonları
            //mıtlak değer fonskiyonu

            

            int sayi;
            
            Console.Write("mutlak değerini istediğiniz sayiyi girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 0)
            {
                sayi = sayi * -1;
                Console.WriteLine(sayi);
            }
            else if (sayi == 0)
            {
                Console.WriteLine("girilen sayı sıfırdır");
            }
            else
            {
                Console.WriteLine(sayi);
            }
            Console.Read();

            //hazır komut Math.Abs

            int say;
            Console.Write("sayı girin: ");
            say = Convert.ToInt32(Console.ReadLine());
            Console.Write("mutlak değer hali: "+ Math.Abs(say));
            Console.Read();

            //Abs yerine Ceiling komutu kullanılırsa sayı yukarı yuvarlanır
            //Abs yerine Cos komutu kullanılırsa sayının cos değeri yazar
            //Abs yerine Sin komutu kullanılırsa sayının sin değeri yazar
            //Abs yerine Floor komutu kullanılırsa sayı aşağı yuvarlanır
            //Abs yerine Sqrt komutu kullanılırsa sayının karekökü alınır
            //Math.Pow üst alma komutu

            int sayi2;
            Console.WriteLine("sayi girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sonuc: " + Math.Pow(sayi2,5));
                             //sayi2 yazılan yer taban 5 yazılan yer üst kısmı 
            //pow yerine Max komutu kullanlırsa iki sayıdan büyük olanı bulunur
                             // sayi2 yazan yere ve 5 yazan yere gelen sayıları karşılaştırır
            //pow yerine Min komutu kullanlırsa iki sayıdan küçük olanı bulunur
                             // sayi2 yazan yere ve 5 yazan yere gelen sayıları karşılaştırır
        }
    }
}
