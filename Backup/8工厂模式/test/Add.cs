using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
   public class Add:Calculate
    {
     
       public override double GetResult()
       {
           return  Num1 + Num2;
       }
    }
}
