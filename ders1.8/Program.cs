using System;

namespace ders1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            char harf;
            harf = 'S';
            Console.WriteLine(harf);

            //ikinci örnek


            char cinsiyet;
            Console.Write("cinsiyet girin: ");
            cinsiyet = Convert.ToChar(Console.ReadLine());
            if(cinsiyet=='e' || cinsiyet == 'E')
            {
                Console.WriteLine("seçilen cinsiyet: erkektir.");
            }
            else
            {
                Console.WriteLine("seçilen cisiyet: kadındır.");
            }
            Console.ReadLine();

            // veri tiplerinin basamak değerlerini araştır öğren...
        }
    }
}
