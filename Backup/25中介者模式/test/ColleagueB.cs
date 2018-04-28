using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25中介者模式.test
{
    class ColleagueB:Colleague
    {
        public ColleagueB(Mediator m):base(m) 
        {
         
        }

        public void Send(string msg)
        {
            mediator.Send(msg,this);
        }

        public void Notice(string msg) 
        {
            Console.WriteLine("同事B收到消息:"+msg);
        }
    }
}
