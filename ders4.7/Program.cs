using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0, hesap = 0;
            int secim=0,dongu = 0,adet;
            string istek;

            Console.WriteLine("***************************************************************");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**          yemekler          **          içeçekler          **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**  1) et döner    - 7.00 TL  **  7) ayran        - 1.00 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**  2) tavuk döner - 5.00 TL  **  8) kola         - 3.00 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**  3) çorbalar    - 4.00 TL  **  9) su           - 0.50 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**  4) salatalar   - 2.50 TL  **  10) çay         - 0.75 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**  5) kuru/pilav  - 6.00 TL  **  11) fanta       - 2.00 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**  6) pide        - 6.50 TL  **  12) soda        - 1.00 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("***************************************************************");

            while (dongu == 0)
            {
             tekrarsec:
                Console.WriteLine("**");
                Console.Write("alacapınız ürün numarası girin: ");
                secim = Convert.ToInt32(Console.ReadLine());
                if(secim<1 || secim > 12)
                {
                    Console.WriteLine("yanlış numara tekrar deneyin: \n");
                    goto tekrarsec;
                }
             tekrar:
                Console.Write("ürün adet/porsiyon sayısı: ");
                adet = Convert.ToInt32(Console.ReadLine());
                if (adet > 0)
                {

                }
                else
                {
                    Console.WriteLine("hatalı seçim tekrar deneyin: \n");
                    goto tekrar;
                }
                switch (secim)
                {
                    case 1:  toplam = adet * 7;    hesap = hesap + toplam; break;
                    case 2:  toplam = adet * 5;    hesap = hesap + toplam; break; 
                    case 3:  toplam = adet * 4;    hesap = hesap + toplam; break; 
                    case 4:  toplam = adet * 2.50; hesap = hesap + toplam; break; 
                    case 5:  toplam = adet * 6;    hesap = hesap + toplam; break; 
                    case 6:  toplam = adet * 6.50; hesap = hesap + toplam; break; 
                    case 7:  toplam = adet * 1;    hesap = hesap + toplam; break; 
                    case 8:  toplam = adet * 3;    hesap = hesap + toplam; break; 
                    case 9:  toplam = adet * 0.50; hesap = hesap + toplam; break; 
                    case 10: toplam = adet * 0.75; hesap = hesap + toplam; break; 
                    case 11: toplam = adet * 2;    hesap = hesap + toplam; break; 
                    case 12: toplam = adet * 1;    hesap = hesap + toplam; break; 
                }
                Console.Write("başka bir isteğiniz var mı (evet=e)?: ");
                istek = Console.ReadLine();
                if(istek=="e" || istek=="E" || istek == "evet")
                {
                    dongu = 0;
                }
                else
                {
                    dongu = 1;
                }
            }
            Console.WriteLine("siparişiniz hazırlanıyor afiyet olsun...");
            Console.WriteLine("hesap: {0} TL",hesap);
            Console.Read();
        }
    }
}
