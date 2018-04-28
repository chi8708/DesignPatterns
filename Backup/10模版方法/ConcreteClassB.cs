using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10模版方法
{
    class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("B实现具体方法1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("B实现具体方法2");
        }
       
    }
}
