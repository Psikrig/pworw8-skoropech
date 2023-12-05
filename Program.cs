using pwork8__skoropech;
using System.Reflection.PortableExecutable;

void text1()
{
    Console.WriteLine("Ввекдите имя для таблицы рекордов");
    pech.name = Console.ReadLine();
    Console.Clear();
    char[] alpha = " The word helmbarte or variations thereof show up in german texts from the 13th century onwards. At that point, the halberd is not too distinct from other types of broad axes or bardiches used all over Europe. In the late 13th century the weapon starts to develop into a distinct weapon, with the top of the blade developing into a more acute thrusting point. This form of the halberd is errorenously sometimes called a voulge or a swiss voulge, but theres no evidence for the usage of these terms for this weapon historically. There were variations of these weapons with spikes on the back, though also plenty without. In the early 15th century the construction changes to incorporate sockets into the blade, instead of hoops as the previous designs had. With this development back spikes are directly integrated into the blade construction and become a universal part of the halberd design.".ToCharArray();
    int l = 0;
    foreach (var h in alpha)
    {
        Console.Write(h);
        l++;
        if (l == 100)
        {
            Console.WriteLine();
            l = 0;
        }
    }
    Console.WriteLine("\r\n Нажмите enter для старта");
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Enter)
        {
            break;
        }
    }
    potoc.Thread.Start();
    pech.textm = pech.Test(alpha);
    pech.texts = pech.textm / 60;
    Thread.CurrentThread.Abort();
    Console.WriteLine("Ваши результаты: символов в минуту: " + pech.textm + ", символов в секунду: " + pech.texts);
    while (true)
    {
        Console.WriteLine("Хотите ли вы попробывать еще раз? enter - да, esc - нет");
        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Enter)
        {
            text1();
        }
        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }
    }
}
text1();

