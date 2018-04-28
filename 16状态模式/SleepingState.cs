using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16状态模式
{
    class SleepingState:State
    {
        public override void WirteProgram(Work w)
        {
            Console.WriteLine("下班回家睡觉中。。。" + w.Hour); w.WriteProgram();
        }
    }
}
