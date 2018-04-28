using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _24职责链模式.test;

namespace _24职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler a = new HandlerA();
            Handler b = new HandlerB();
            Handler c = new HandlerC();

            a.setHandler(b);
            b.setHandler(c);

            int[] requestArr = { 2, 3, 12, 1, 25, 10 };
            foreach (var item in requestArr)
            {
                a.HandleRequest(item);
                //循环给最小处理者
            }
            Console.ReadKey();
        }
    }
}
