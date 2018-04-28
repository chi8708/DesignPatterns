using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂
{
   public class Mul:Calculate
    {
       public override double GetResult()
       {
           return Num1 * Num2;
       }
    }
}
