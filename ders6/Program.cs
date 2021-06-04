using System;

namespace ders6
{
    class Program
    {
        static void Main(string[] args)
        {

            //ilk örnek
            string isim;
            Console.Write("isim giriniz: ");
            isim = Console.ReadLine();

            if (isim == "burak")
            {
                Console.WriteLine("doğru isim girişi.\nhoşgeldiniz: "+isim);
            }
            else
            {
                Console.WriteLine("hatalı isim girisi: DİKKAT !!!");
            }

            Console.Read();
            
            //ikinci örnek
            int sayi;
            Console.Write("sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 0)
            {
                Console.WriteLine("sayi negatiftir.");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("sayi pozitiftir.");
            }
            else
            {
                Console.WriteLine("sayi sıfırdır.\nnötr.");
            }
            Console.Read();
            
            //üçüncü örnek 

            int sinav, sinav2, ort;

            Console.Write("ilk sınav notunuzu giriniz: ");
            sinav = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikici sınav notunuzu giriniz: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            ort = (sinav + sinav2)/2;

            if (ort >= 50)
            {
                Console.WriteLine("tebrikler geçtiniz.");
            }
            else
            {
                Console.WriteLine("üzgünüm kaldınız. ");
            }

            Console.Read();
        }
    }
}
