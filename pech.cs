using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pwork8__skoropech
{
    internal class pech
    {
        public static int texts;
        public static int textm;
        public static String name;
        public static int Test(char[] alpha)
        {

            int pos = 0;
            int str = 0;

            int text = 0;
            while (potoc.b == 0)
            {
                text = str * 100 + pos;
                if (text == 891) { potoc.b = 1; }
                Console.SetCursorPosition(pos, str);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.KeyChar != alpha[text])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(alpha[text]);
                }
                if (key.KeyChar == alpha[text])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(alpha[text]);
                    pos++;
                    if (pos == 101)
                    {
                        pos = 0;
                        str++;
                    }
                }
            }
            return text;
        }
    }
}
