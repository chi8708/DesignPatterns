using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16状态模式
{
    class EveningState:State
    {
        public override void WirteProgram(Work w)
        {

                if (!w.Finsh)
                {
                    Console.WriteLine("晚上{0}点加班中", w.Hour);
                }
                else 
                {
                    w.SetState(new SleepingState()); w.WriteProgram();
                }
                
         
        }
    }
}
