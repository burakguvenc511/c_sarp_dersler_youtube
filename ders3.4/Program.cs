using System;

namespace ders3._4
{
    class Methodlar
    {
        int topla(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Methodlar mtd = new Methodlar();
            int z = mtd.topla(4,5);
            Console.WriteLine(z);
           
            Console.Read();
        }
    }
}
