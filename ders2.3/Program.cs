using System;

namespace ders2._3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.BackgroundColor = ConsoleColor.DarkRed;     //arka plan rengi düzenler
            Console.ForegroundColor = ConsoleColor.Yellow;      // yazı rengi düzenler
            Console.Title = "burak guvenc";                     // console başlığı değiştirir
            Console.Clear();                                    // console ekranını temizler
            Console.WriteLine("bahtsız bedeviler");
            Console.ReadLine();


            // ikinci örnek


            Console.Write("0-15 arası değer girin: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = renk;
            Console.Clear();
            Console.ReadLine();


            //ödev

            Console.Title = "şehirler";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("çanakkale");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("kahramanMaraş");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("sivas");
            Console.ReadLine();

        }
    }
} 
