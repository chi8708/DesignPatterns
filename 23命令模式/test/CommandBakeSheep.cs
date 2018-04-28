using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23命令模式.test
{
    class CommandBakeSheep:Command
    {
        public CommandBakeSheep(Reciver reciver) : base(reciver) 
        {
        
        }

        public override void Bake()
        {
            base.reciver.BakeSheep();
        }
    }
}
