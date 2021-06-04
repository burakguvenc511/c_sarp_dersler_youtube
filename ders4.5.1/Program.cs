using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ders4._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol,yol2,yol3,yol4;
            int gs = 0, fb = 0, ts = 0, bjk = 0;
            int sayac = 1;
            int a, b, c, d;
            Console.WriteLine("lig turnuvasına hoşgeldiniz...");
            Console.WriteLine("------------------------------");
            Random rastgele = new Random();

            while (sayac < 4)
            {
                a = rastgele.Next(0, 6);    //gs
                b = rastgele.Next(0, 6);    //fb
                c = rastgele.Next(0, 6);    //ts
                d = rastgele.Next(0, 6);    //bjk
                Console.Read();
                Console.WriteLine("{0}. hafta maç sonuçları: ", sayac);
                Console.WriteLine("------------------------------\n");
                switch (sayac)
                {
                    case 1:
                        Console.WriteLine("galatasaray {0} - {1} fenerbahçe", a, b);
                        Console.WriteLine("trabzonspor {0} - {1} beşiktaş\n\n", c, d);
                        if (a > b) { gs = gs + 3; }
                        if (b > a) { fb = fb + 3; }
                        if (a == b) { gs = gs + 1; fb = fb + 1; }

                        if (c > d) { ts = ts + 3; }
                        if (d > c) { bjk = bjk + 3; }
                        if (c == d) { ts = ts + 1; bjk = bjk + 1; }

                        break;
                    case 2:
                        Console.WriteLine("galatasaray {0} - {1} trabzonspor", a, c);
                        Console.WriteLine("fenerbahçe  {0} - {1} beşiktaş\n\n", b, d);
                        if (a > c) { gs = gs + 3; }
                        if (c > a) { ts = ts + 3; }
                        if (a == c) { gs = gs + 1; ts = ts + 1; }

                        if (b > d) { fb = fb + 3; }
                        if (d > b) { bjk = bjk + 3; }
                        if (b == d) { fb = fb + 1; bjk = bjk + 1; }

                        break;
                    case 3:
                        Console.WriteLine("galatasaray {0} - {1} beşiktaş", a, d);
                        Console.WriteLine("trabzonspor {0} - {1} fenerbahçe\n\n", c, b);
                        if (a > d) { gs = gs + 3; }
                        if (d > a) { bjk = bjk + 3; }
                        if (a == d) { gs = gs + 1; bjk = bjk + 1; }

                        if (b > c) { fb = fb + 3; }
                        if (c > b) { ts = ts + 3; }
                        if (b == c) { fb = fb + 1; ts = ts + 1; }

                        break;
                }
                sayac++;

                Console.Read();
            }
            Console.WriteLine("\npuan tablosu\n");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("galatasaray: "+gs);
            Console.WriteLine("fenerbahçe : "+fb);
            Console.WriteLine("trabzonspor: "+ts);
            Console.WriteLine("beşiktaş   : "+bjk);
            sampiyon:
            Console.WriteLine("\n\n");
            if (gs > fb && gs > ts && gs > bjk)
            {
                Console.WriteLine("ŞAMPİYON takım GALATASARAY");
                Console.WriteLine("GALATASARAY MARŞI başlatılıyor");
                yol = @"C:\Users\guven\Desktop\müzik\Galatasaray-Şereftir-Seni-Sevmek.wav";
                ses.SoundLocation = yol;
                ses.Play();
                Console.WriteLine("\n( şarkıyı bitirmek için enter a basın )\n\n");
                Console.Read();
            }

            if (fb > gs && fb > ts && fb > bjk)
            {
                Console.WriteLine("ŞAMPİYON takım FENERBAHÇE");
                Console.WriteLine("FENERBAHÇE MARŞI başlatılıyor");
                yol2 = @"C:\Users\guven\Desktop\müzik\100yil_marsi_Kirac.wav";
                ses.SoundLocation = yol2;
                ses.Play();
                Console.WriteLine("\n( şarkıyı bitirmek için enter a basın )\n\n");
                Console.Read();
            }

            if (ts > fb && ts > gs && ts > bjk)
            {
                Console.WriteLine("ŞAMPİYON takım TRABZONSPOR");
                Console.WriteLine("TRABZONSPOR MARŞI başlatılıyor");
                yol3 = @"C:\Users\guven\Desktop\müzik\Trabzonspor - 50. Yıl Marşı.wav";
                ses.SoundLocation = yol3;
                ses.Play();
                Console.WriteLine("\n( şarkıyı bitirmek için enter a basın )\n\n");
                Console.Read();
            }

            if (bjk > fb && bjk > ts && bjk > gs)
            {
                Console.WriteLine("ŞAMPİYON takım BEŞİKTAŞ");
                Console.WriteLine("BEŞİKTAŞ MARŞI başlatılıyor");
                yol4 = @"C:\Users\guven\Desktop\müzik\mp3indirdur-Besiktas-Marslari-Besiktasim-Sevmisiz-Seni.wav";
                ses.SoundLocation = yol4;
                ses.Play();
                Console.WriteLine("\n( şarkıyı bitirmek için enter a basın )\n\n");
                Console.Read();
            }
            gsfb:
            if(gs==fb && fb>ts && fb> bjk)
            {
                a = rastgele.Next(0, 6);    //gs
                b = rastgele.Next(0, 6);    //fb
                Console.Read();
                Console.WriteLine("final derbi maçı: ");
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("galatasaray {0} - {1} fenerbahçe\n\n",a,b);
                if (a > b)   { gs = gs + 3;   goto sampiyon;  }
                if (b > a)   { fb = fb + 3;   goto sampiyon;  }
                if (a == b)  { goto gsfb;      }
            }
            gsts:
            if(gs == ts && ts > fb && ts > bjk)
            {
                a = rastgele.Next(0, 6);    //gs
                c = rastgele.Next(0, 6);    //ts
                Console.Read();
                Console.WriteLine("final derbi maçı: ");
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("galatasaray {0} - {1} trabzonspor\n\n", a, c);
                if (a > c)   { gs = gs + 3;   goto sampiyon;  }
                if (c > a)   { ts = ts + 3;   goto sampiyon;  }
                if (a == c)  { goto gsts;      }
            }
            gsbjk:
            if (gs == bjk && bjk > fb && bjk > ts)
            {
                a = rastgele.Next(0, 6);    //gs
                d = rastgele.Next(0, 6);    //bjk
                Console.Read();
                Console.WriteLine("final derbi maçı: ");
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("galatasaray {0} - {1} beşiktaş\n\n", a, d);
                if (a > d)   { gs = gs + 3;   goto sampiyon;  }
                if (d > a)   { bjk = bjk + 3; goto sampiyon;  }
                if (a == d)  { goto gsbjk;     }
            }
            fbts:
            if (fb == ts && ts > gs && ts > bjk)
            {
                b = rastgele.Next(0, 6);    //fb
                c = rastgele.Next(0, 6);    //ts
                Console.Read();
                Console.WriteLine("final derbi maçı: ");
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("fenerbahçe {0} - {1} trabzonspor\n\n", b, c);
                if (b > c)   { fb = fb + 3;  goto sampiyon;   }
                if (c > b)   { ts = ts + 3;  goto sampiyon;   } 
                if (b == c)  { goto fbts;     }
            }
            fbbjk:
            if (fb == bjk && bjk > gs && bjk > ts)
            {
                b = rastgele.Next(0, 6);    //fb
                d = rastgele.Next(0, 6);    //bjk
                Console.Read();
                Console.WriteLine("final derbi maçı: ");
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("fenerbahçe {0} - {1} beşiktaş\n\n", b, d);
                if (b > d)   { fb = fb + 3;   goto sampiyon; }
                if (d > b)   { bjk = bjk + 3; goto sampiyon; }
                if (b == d)  { goto fbbjk;     }
            }
            tsbjk:
            if (ts == bjk && bjk > gs && bjk > fb)
            {
                c = rastgele.Next(0, 6);    //ts
                d = rastgele.Next(0, 6);    //bjk
                Console.Read();
                Console.WriteLine("final derbi maçı: ");
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("trabzonspor {0} - {1} beşiktaş\n\n", c, d);
                if (c > d)   { ts = ts + 3;   goto sampiyon; }
                if (d > c)   { bjk = bjk + 3; goto sampiyon; }
                if (c == d)  { goto tsbjk;     }
            }
            Console.Read();
        }
    }
}