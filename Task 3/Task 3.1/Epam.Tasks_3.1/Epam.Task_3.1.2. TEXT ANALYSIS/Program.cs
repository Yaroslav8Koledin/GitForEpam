using System;
using System.Collections.Generic;

namespace Epam.Task_3._1._2.TEXT_ANALYSIS
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите текст");
            Console.Write("ВВОД: ");
            string str = Console.ReadLine();
            //"I’m Greg. I’m nine. I have got have have a nice red cat have cat. It can jump and run. But I haven’t got a Greg dog, and I’m sad. This is Rob. He is three. He has got a little yellow fish! The fish is nice. It can swim. Rob is happy. This is Jillian this. She has got four little kittens. Jillian is happy, too.".CheckText();
            str.CheckText();
        }
    }
}
