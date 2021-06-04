using System;
using System.Collections.Generic;
using System.Text;

namespace ders3._9
{
    class insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "HELLO WORLD";
            Console.WriteLine("merhaba sıcak yaz günleri"); ;
        }
    }
    class turk : insan
    {
        public override void selamver()
        {
            Console.WriteLine("esenlikler");
        }
    }
    class fransiz : insan
    {
        public override void selamver()
        {
            Console.WriteLine("bonjour");
        }
    }
    class ingiliz : insan
    {
        public override void selamver()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("hello");
        }
    }
}
