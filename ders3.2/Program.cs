using System;

namespace ders3._2
{
    class Program
    {
        public static void veriler()
        {
            Console.WriteLine("müdür: hebele");
            Console.WriteLine("yardımcı: hübele");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.Write("\n");
            
        }

        static void Main(string[] args)
        {
            //methodlar
            veriler();

            for (int i = 0; i < 5; i++)
            {
                veriler();
            }
            //her yazıldığında yeniden bilgileri tekrarlar.
            //tek tek de yazılabilir döngü içerisinde de.
        }
    }
}
