using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16状态模式
{
   public class ForeNoonState:State
    {

        public override void WirteProgram(Work w)
        {
            if (w.Hour<12)
            {
                Console.WriteLine("早上{0}点工作中",w.Hour);
            }
            else
            {
                w.SetState(new NoonState()); w.WriteProgram();
            }
        }
    }
}
