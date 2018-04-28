using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            w.Hour = 11;
            w.WriteProgram();
            w.Hour = 15;
            w.WriteProgram();
            w.Hour = 16;
            w.WriteProgram();
            w.Hour = 20;

            w.Finsh = false;
            w.WriteProgram();

            Console.ReadKey();

        }
    }
}
