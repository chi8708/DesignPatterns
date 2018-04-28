using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
   public class CalculateFactory
    {
       
       public static Calculate CreateOperate(string opr) 
       {
          // Calculate cal = null;
           IoperateFactory orpfactry = null;
           switch (opr)
           {
               case"+":
                   //cal = new Add();
                   orpfactry = new IAddFactory();
                   break;
               case"-":
                   //cal = new Sub();
                   orpfactry = new ISubFactory();
                   break;
               case"*":
                   //cal = new Mul();
                   orpfactry = new IMulFactory();
                   break;
               case"/":
                   //cal=new Div();
                   orpfactry = new IDivFactory();
                   break;

               default:
                   throw new Exception("运算符不存在");
                   break;

           }

           //return cal;
           return orpfactry.CreateOperate();
       }
    }
}
