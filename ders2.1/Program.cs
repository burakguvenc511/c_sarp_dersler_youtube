using System;

namespace ders2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte
            byte s1, s2;
            s1 = 20;                         // byte lar [0-255] arası değer alabilirler
            s2 = 255;                        // console.writeLine içinde toplarsanız bu sayıları int olarak alıp toplayacaktır.
            Console.WriteLine(s1+s2);        // ancak byte türünde bir toplama değişkeni oluşturup toplarsanız
                                             // toplam sonucu 255 üstüne geldiinde mod alma işlemine dönüşür.
                                             // normaal toplama yapmak için boxing yapılması gerek ileri konularda anlatılacak
            //sbyte
            Console.WriteLine("--- doğu anadolu hava durumu ---");  
            Console.WriteLine("1 ocak 2020 hava tahmini");
            sbyte erzurum, malatya, elazig;
            erzurum = -35;                      
            malatya = 3;                    // sbyte lar [-128-127] arası değer alabilirler
            elazig = -7;

            Console.WriteLine("ezrurum karlı: "+erzurum+" C");
            Console.WriteLine("malatya parçalı bulutlu: "+ malatya+" C");
            Console.WriteLine("elazığ yağışlı: "+elazig+" C");


            //short

            short say1, say2, say3;
            say1 = -32768;                 // short lar [-32768-32767] arası değerler alabilir.
            say2 = 30;
            say3 = 32767;
            Console.WriteLine(say3+say2+say1);


            //ushort


            ushort sayi, sayi2;
            sayi = 0;                     // ushort lar [0-65535] arası değerler alabilir.
            sayi2 = 65535;
            Console.WriteLine(sayi+sayi2);
            Console.Read();                 
        }   
    }
}
