using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _25中介者模式.test;
using System.Collections;

namespace _25中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();
            ColleagueA a = new ColleagueA(m);
            ColleagueB b = new ColleagueB(m);

            m.A = a;
            m.B = b;

            a.Send("在干吗？");
            b.Send("打游戏");
            Console.ReadKey();
           
        }
    }
}
