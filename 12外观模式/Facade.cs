using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12外观模式
{
    class Facade
    {

        SystemSubA a;
        SystemSubB b;
        SystemSubC c;
       
        public Facade() 
        {

            a = new SystemSubA();
            b = new SystemSubB();
            c = new SystemSubC();
        }

        public void MethodA() 
        {

            a.MethodOne();
            b.MethodTwo();
       
        }

        public void MethodB() 
        {

            b.MethodTwo();
            c.MethodThree();
        }
    }

}
