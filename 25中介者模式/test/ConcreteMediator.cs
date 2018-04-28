using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25中介者模式.test
{
    class ConcreteMediator:Mediator
    {
        private ColleagueA a = null;
        private ColleagueB b = null;

        public ColleagueA A 
        {
            set { this.a = value; }
        }
        public ColleagueB B 
        {
            set { this.b = value; }
        }

        public override void Send(string msg, Colleague c)
        {
            if (c==a)
            {
                b.Notice(msg);
            }
            else
            {
                a.Notice(msg);
            }
        }
    }
}
