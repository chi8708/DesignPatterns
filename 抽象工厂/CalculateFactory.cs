using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂
{
   public class CalculateFactory
    {
       public static Calculate CreateOperate(string opr) 
       {
           Calculate cal = null;
           switch (opr)
           {
               case"+":
                   cal = new Add();
                   break;
               case"-":
                   cal = new Sub();
                   break;
               case"*":
                   cal = new Mul();
                   break;
               case"/":
                   cal=new Div();
                   break;

               default:
                   throw new Exception("运算符不存在");
                   break;

           }

           return cal;
       }
    }
}
