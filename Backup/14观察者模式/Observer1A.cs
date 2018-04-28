using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式
{
    class Observer1A:Observer1
    {
        public Observer1A(string name, Subject sub) : base(name, sub) { }
        public override void Update()
        {
            Console.WriteLine("{0}在看NBA 继续工作{1}",name,sub.Action);
        }
    }
}
