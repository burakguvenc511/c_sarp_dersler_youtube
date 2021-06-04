using System;

namespace ders2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // veri tiplerinin basamak değerlerini araştır öğren...
            //decimal

            decimal s1;
            int s2;                 // 29 basamak kapasitesi vardır. sonuna  m hafi gelmelidir.
            s1=2.46m;
            s2 = 23;
            decimal toplam;
            toplam = s1 + s2;
            Console.WriteLine("toplam: "+toplam);


            //ikinci örnek


            decimal x,y,z;
            x = 0.994m;
            y = 999999;
            z = 0.997m;
            Console.WriteLine("para1: {0:C}",x);
            Console.WriteLine("para 2: {0:C}",y);       // " :C " komutu sayıyı parasal değer gibi basamaklarına ayırarak yazar ve yuvarlar.
            Console.WriteLine("para 3: {0:C}",z);       
            Console.WriteLine("x: "+x);
            Console.WriteLine("y: "+y);
            Console.WriteLine("z: "+z);



            //üçüncü örnek


            decimal urun1, urun2, top;
            int say1, say2;
            urun1 = 14.8m;
            urun2 = 28.90m;
            Console.Write("urun 1 satış sayısı girin: ");
            say1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("urun 2 satış sayısı girin: ");
            say2 = Convert.ToInt16(Console.ReadLine());
            top = say1 * urun1 + say2 * urun2;
            Console.WriteLine("kasada olması gereken toplam miktar "+top+" TL dir.");
            Console.Read();
        }
    }
}
