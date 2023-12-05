   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwork8__skoropech
{
    internal class potoc
    {
        static public int b = 0;
        public static Thread Thread = new Thread(new ThreadStart(vrem));
        public static void vrem()
        { 
            int time = 60;
            while (true)
            {
                Thread.Sleep(1000);
                time--;
                Console.SetCursorPosition(0, 15);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("осталось " + time + " сек");
                if (time == 0)
                {
                    potoc.b = 1;
                }
            }
        }
    }
}
