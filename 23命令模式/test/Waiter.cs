using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23命令模式.test
{
    class Waiter
    {
        Command cm = null;
        public void SetOrder(Command command) 
        {
            this.cm = command;
        }

        public void Notice() 
        {
            cm.Bake();
        }
    }
}
