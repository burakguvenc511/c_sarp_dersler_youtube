using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ders4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = @"‪C:\Users\guven\Desktop\müzik\Galatasaray-Şereftir-Seni-Sevmek";
            ses.SoundLocation = yol;
            ses.Play();
            Console.Read();
        }
    }
}
