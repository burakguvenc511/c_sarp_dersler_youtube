
using System;

namespace ders4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim,islem;
            double sayi1, sayi2, toplam, cikarma, carpma,bolme;
            
            Console.WriteLine("*** aritmetik işlemler menüsüne hoşgeldiniz ***\n");
            Console.WriteLine("1) aritmetik dört işlem");
            Console.WriteLine("2) üst alma");
            Console.WriteLine("3) karekök alma");
            Console.WriteLine("4) kare çevre ve alan bulma");
            Console.WriteLine("5) dikdörtgen çevre ve alan bulma");
            Console.WriteLine("6) eşkenar üçgende çevre");

            Console.Write("işlem seçin: ");
            secim = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 1: 
                    Console.WriteLine("1) toplama");
                    Console.WriteLine("2) çıkarma");
                    Console.WriteLine("3) çarpma");
                    Console.WriteLine("4) bölme");
                    Console.Write("işlem seçin: ");
                    islem = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
   
                    switch (islem)
                    {
                        case 1:
                            Console.WriteLine("toplama: \n");
                            Console.Write("1. sayıyı girin: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2. sayıyı girin: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            toplam = sayi2 + sayi1;
                            Console.Write("sonuç: "+toplam);
                            break;
                        case 2:
                            Console.WriteLine("çıkarma: \n");
                            Console.Write("1. sayıyı girin: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2. sayıyı girin: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            cikarma = sayi1 - sayi2;
                            Console.Write("sonuç: "+cikarma);
                            break;
                        case 3:
                            Console.WriteLine("carpma: \n");
                            Console.Write("1. sayıyı girin: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2. sayıyı girin: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            carpma = sayi1 * sayi2;
                            Console.Write("sonuç: " + carpma);
                            break;
                        case 4:
                            Console.WriteLine("bolme: \n");
                            Console.Write("1. sayıyı girin: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2. sayıyı girin: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            bolme = sayi1 / sayi2;
                            Console.Write("sonuç: " + bolme);
                            break;
                    }
                        break;

                case 2:
                    Console.WriteLine("üst alma: \n");
                    Console.Write("1. sayıyı girin (taban): ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı girin (üst): ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("sonuç: "+ Math.Pow(sayi1, sayi2));

                    break;
                case 3:
                    Console.WriteLine("kök alma: \n");
                    Console.Write("sayıyı girin (kök): ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("sonuç: "+Math.Sqrt(sayi1));
                    break;
                case 4:
                    Console.WriteLine("kare çevre ve alan: \n");
                    Console.Write("sayıyı girin (kenar uzunluğu): ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("çevre sonuç: "+sayi1*4);
                    Console.WriteLine("alan sonuç: "+sayi1*sayi1);
                    break;
                case 5:
                    Console.WriteLine("dikdörtgen çevre ve alan: \n");
                    Console.Write("1. sayıyı girin (kısa kenar): ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı girin (uzun kenar): ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("çevre sonuç: "+((sayi1*2)+(sayi2*2)));
                    Console.WriteLine("alan sonuç: "+sayi1*sayi2);
                    break;
                case 6:
                    Console.WriteLine("eşkenar üçgen çevre: \n");
                    Console.WriteLine("sayi girin (kenar uzunluğu): ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("sonuç: "+sayi1*3);
                    break;
            }

        }
    }
}