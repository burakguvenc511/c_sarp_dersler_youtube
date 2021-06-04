using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ders4._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = @"C:\Users\guven\Desktop\Galatasaray-Şereftir-Seni-Sevmek.wav";
            ses.SoundLocation = yol;
            ses.Play();

            //yukarıdaki satır kodları şarkıyı arka planda açar konsol ekranı kapanınca şarkı da kapanır

            // aşağıdaki satır kodları şarkıyı açar ancak medya player kullanır
            
            System.Diagnostics.Process.Start(@"C:\Users\guven\Desktop\müzik\Galatasaray - Şereftir Seni Sevmek.mp3");
            

            Console.Read();

        }
    }
}

