using System;

namespace ders1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            float deger;
            deger = 1234567;
            Console.WriteLine("değer: " + deger);


            float sayi;
            sayi = 2.12345678f;     // float değişkeni için değer sonuna buyuk ya da küçük "f" konur.  float 7 karakter desteklidir.
            Console.WriteLine(sayi);
            

            //ikinci örnek

            int x = 5;
            float y = 2.6F;
            int z = 3;
            float toplam = x + y + z;     //toplam int değil float olacak çüntü toplam içinde float değerler de mevcut
            Console.WriteLine(toplam);
            Console.Read();


            // veri tiplerinin basamak değerlerini araştır öğren...
        }
    }
}
