using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ders4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter dosya = new StreamWriter(@"C:\Users\guven\Desktop\GAME\gün.txt");
            string veri;
            Console.WriteLine("notunuzu(metninizi) girin:");
            veri = Console.ReadLine();
            dosya.WriteLine(veri);
            dosya.Close();
            Console.Read();
        }
    }
}
