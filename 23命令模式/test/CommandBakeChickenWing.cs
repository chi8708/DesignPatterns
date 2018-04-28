using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23命令模式.test
{
    class CommandBakeChickenWing:Command
    {
        public CommandBakeChickenWing(Reciver reciver)
            : base(reciver) 
        {
        
        }

        public override void Bake()
        {
            base.reciver.BakeChickenWing();
        }
    }
}
