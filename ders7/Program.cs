using System;

namespace ders7
{
    class Program
    {
        static void Main(string[] args)
        {
            int not, not2,proje, ort;
            Console.Write("ilk notunuzu girin: ");
            not = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci notunuzu girin: ");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("proje notu girin: ");
            proje = Convert.ToInt32(Console.ReadLine());
            ort = (not + not2 + proje) / 3;
            Console.WriteLine();
            Console.WriteLine("ortalamanız: "+ort);
            Console.WriteLine();

            if(ort>0 && ort < 30)
            {
                Console.WriteLine("durum: çok kötü");
            }
            else if(ort>=30 && ort < 50)
            {
                Console.WriteLine("durum: kötü");
            }
            else if(ort>=50 && ort < 80)
            {
                Console.WriteLine("durum: iyi");
            }
            else if(ort>=80 && ort < 101)
            {
                Console.WriteLine("durum: çok iyi");
            }
            Console.Read();
            


            //ikinci ornek



            int sayi,gecici;
            Console.Write("sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            gecici=sayi % 2;
            if (gecici == 0)
            {
                Console.WriteLine("girdiğiniz sayi çifttir.");
            }
            else if (gecici == 1)
            {
                Console.WriteLine("girdiğiniz sayi tektir.");
            }
            Console.Read();
        }
    }
}
