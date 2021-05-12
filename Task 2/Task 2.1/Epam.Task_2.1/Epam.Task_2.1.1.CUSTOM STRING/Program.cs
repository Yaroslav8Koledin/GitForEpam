using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._1._1.CUSTOM_STRING
{
    internal class Program
    {
        private static void Main()
        {
            MyString a = new MyString("Hello");
            a.Insert(5, " world!");
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.GetHashCode());
        }
    }
}
