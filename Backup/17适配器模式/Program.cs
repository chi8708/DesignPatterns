using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Target t = new Adapter();
            //t.Request();
            //Console.ReadKey();

            Player p1 = new Forward("巴蒂尔");
            p1.Attack();

            Player p2 = new Guard("麦蒂");
            p2.Attack();
            p2.Defense();

            Player p3=new Translator("ym");
           // p3.Name = "姚明";
            p3.Attack();
            Console.ReadKey();
        }
    }
}
