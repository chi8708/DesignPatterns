using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10模版方法
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();
            Console.WriteLine("\n");
            AbstractClass b = new ConcreteClassB();
            b.TemplateMethod();

            Console.ReadKey();
        }
    }
}
