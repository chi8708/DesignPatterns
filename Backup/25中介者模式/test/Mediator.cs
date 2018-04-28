using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25中介者模式.test
{
    abstract class Mediator
    {
        public abstract void Send(string msg,Colleague c);
    }
}
