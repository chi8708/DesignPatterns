using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28访问者模式
{
    class Woman : Person
    {
        public override void Action(Action a)
        {
            a.GetWomanAction(this);
        }
    }
}
