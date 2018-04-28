using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25中介者模式.test
{
    abstract class Colleague
    {
       protected Mediator mediator = null;

        public Colleague(Mediator m) 
        {
            mediator = m;
        }
    }
}
