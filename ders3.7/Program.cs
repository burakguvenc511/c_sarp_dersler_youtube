using System;

namespace ders3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            emlak house = new emlak();
            house.Semt = "hürriyet";
            house.Renk = "beyaz";
            house.OdaSayisi = 5;
            house.KatNo = 3;
            house.Alan = 150;

            Console.WriteLine("evin bulunduğu semt: "+house.Semt);
            Console.WriteLine("evin rengi: " + house.Renk);
            Console.WriteLine("evin oda sayısı: " + house.OdaSayisi);
            Console.WriteLine("evin bulunduğu kat: " + house.KatNo);
            Console.WriteLine("evin alanı: " + house.Alan + " m2");
        }
    }
}
