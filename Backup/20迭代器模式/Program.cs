using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _20迭代器模式.test;

namespace _20迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggrate a = new ConcreteAggrate();
            a[0] = "张三";
            a[1] = "李四";

            Iterator i = new ConcreteIteratorDESC(a);
            object o=i.First();
            while(!i.IsDone())
            {
                Console.WriteLine(i.CurrentItem()+"买票");
                i.Next();
            }

            Console.ReadKey();

            
        }
    }
}
