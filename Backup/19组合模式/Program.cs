using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _19组合模式.test;

namespace _19组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("root");

            Component n1 = new Composite("node1");
            root.Add(n1);

            Component n2=new Composite("node2");
            root.Add(n2);

            Component n1_1 = new Composite("node1.1");
            n1.Add(n1_1);

            Component leaf1 = new Leaf("left1.1_1");
            n1_1.Add(leaf1);

            root.Display(1);
            Console.ReadKey();
          

        }
    }
}
