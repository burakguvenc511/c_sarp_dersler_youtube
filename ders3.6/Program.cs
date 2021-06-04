using System;

namespace ders3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci();
            ogr.Ad = "burak";
            ogr.SoyAd = "güvenç";
            ogr.Bolum = "sayısal";
            ogr.Yas = 20;

            Console.WriteLine("öğrenci adı: "+ogr.Ad);
            Console.WriteLine("öğrenci sayadı: " + ogr.SoyAd);
            Console.WriteLine("öğrenci bölümü: " + ogr.Bolum);
            Console.WriteLine("öğrenci yaşı: " + ogr.Yas);
        }
    }
}
 