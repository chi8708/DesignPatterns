using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16状态模式
{
    class NoonState : State
    {

        public override void WirteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("中午{0}点工作中", w.Hour);
            }
            else
            {
                w.SetState(new EveningState()); w.WriteProgram();
            }
        }

    }
}
