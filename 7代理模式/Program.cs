using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mm = new SchoolGirl("小样");

            Isend isend = new Agent();
            isend.SendBall(mm);
            Console.ReadKey();
        }
    }
}
