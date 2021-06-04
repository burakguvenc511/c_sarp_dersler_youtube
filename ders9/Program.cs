using System;

namespace ders9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi;
            Console.Write("1-7 arası sayi girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {   
                case 1: Console.WriteLine("gün: pazartesi");            break;
                case 2: Console.WriteLine("gün: salı");                 break;
                case 3: Console.WriteLine("gün: çarşamba");             break;
                case 4: Console.WriteLine("gün: perşembe");             break;
                case 5: Console.WriteLine("gün: cuma");                 break;
                case 6: Console.WriteLine("gün: cumartesi");            break;
                case 7: Console.WriteLine("gün: pazar");                break;
                default: Console.WriteLine("hatalı gün girişi.");       break;
            }
            Console.Read();

            
            // ikinci örnek 


            string mevsim;
            Console.Write("küçük harflerle mevsim giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kış": Console.WriteLine("     kış mevsimi ayları: \n--- aralık --- ocak ---şubat ---");            break;
                case "ilkbahar": Console.WriteLine("     ilkbahar mevsimi ayları: \n---mart --- nisan --- mayıs ---");   break;
                case "yaz": Console.WriteLine("     yaz mevsimi ayları: \n---haziran --- temmuz --- ağustos ---");       break;
                case "sonbahar": Console.WriteLine("     sonbahar mevsimi ayları: \n---eylül --- ekim --- kasım ---");   break;
                default: Console.WriteLine("hatalı mevsim girişi.");                                                     break;
            }
            Console.Read();
        }
    }
}
