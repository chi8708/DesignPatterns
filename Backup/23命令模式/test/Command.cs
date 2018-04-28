using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23命令模式.test
{
    abstract class Command
    {
        protected Reciver reciver=null;

        public Command(Reciver reciver) 
        {
            this.reciver = reciver;
        }

        public abstract void Bake();

    }
}
