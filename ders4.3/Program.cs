using System;

namespace ders4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            again:
            int alt, ust, sayi, cevap, x = 0,deneme=1;
            string tekrar;
            Console.WriteLine("sayı tahmin oyununa hoşgeldiniz: \n");
            Console.Write("al sınır girin: ");
            alt = Convert.ToInt32(Console.ReadLine());
            Console.Write("üst sınır girin: ");
            ust = Convert.ToInt32(Console.ReadLine());
            Random tahmin = new Random();
            sayi = tahmin.Next(alt - 1, ust);
            Console.Write("bir sayı tuttum bulabilir misin ?: ");
            cevap = Convert.ToInt32(Console.ReadLine());

            while (x == 0)
            {
                if (cevap == sayi)
                {
                    Console.WriteLine("\ntebrikler doğru sayıyı {0} denemde buldunuz...",deneme);
                    goto son;
                }
                if (cevap < sayi)
                {
                    Console.WriteLine("\ntuttuğum sayı daha büyük...\n");
                    deneme++;
                }
                if (cevap > sayi)
                {
                    Console.WriteLine("\ntuttuğum sayı daha küçük...\n");
                    deneme++;
                }
                Console.Write("tahminin nedir ?: ");
                cevap = Convert.ToInt32(Console.ReadLine());
            }
        son:
            Console.WriteLine("\n\ntekrar oynamak ister misiniz (evet =e) ?:");
            tekrar = Console.ReadLine();
            if(tekrar== "e" || tekrar == "evet")
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\toyun yeniden başlatılıyor...\n");
                goto again;
            }
            Console.Read();
        }
    }
}