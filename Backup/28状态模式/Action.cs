using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28访问者模式
{
    abstract class Action
    {
        public abstract void GetManAction(Man m);

        public abstract void GetWomanAction(Woman wm);
    }
}
