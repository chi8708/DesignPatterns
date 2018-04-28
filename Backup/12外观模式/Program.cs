using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade a = new Facade();
            a.MethodA();
            Console.WriteLine("\n");
            a.MethodB();
            Console.ReadKey();

        }
    }
}
