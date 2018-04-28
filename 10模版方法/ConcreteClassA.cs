using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10模版方法
{
   class ConcreteClassA:AbstractClass
    {

        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体的A实现方法1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体的A实现方法2");
        }
    }
}
