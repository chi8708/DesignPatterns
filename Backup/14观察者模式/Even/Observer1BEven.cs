using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _14观察者模式.Even;

namespace _14观察者模式
{
    class Observer1BEven:Observer1Even
    {
        public Observer1BEven(string name, SubjectEven sub) : base(name, sub) { }
        public  void SeeSotck()
        {
            Console.WriteLine("{0}在炒股 继续工作{1}",name,sub.Action);
        }
    }
}
