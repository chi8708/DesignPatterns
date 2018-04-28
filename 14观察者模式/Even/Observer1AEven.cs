using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _14观察者模式.Even;

namespace _14观察者模式
{
    class Observer1AEven:Observer1Even
    {
        public Observer1AEven(string name, SubjectEven sub) : base(name, sub) { }
        public  void SeeNBA()
        {
            Console.WriteLine("{0}在看NBA 继续工作{1}",name,sub.Action);
        }
    }
}
