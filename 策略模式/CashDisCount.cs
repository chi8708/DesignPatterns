using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
   public class CashDisCount:CashSuper
    {
       double disCount = 1;
       public CashDisCount(double  disCount) 
       {
           this.disCount =disCount ;
       }

        public override double AcceptCash(double money)
        {
            return money * disCount;
        }
    }
}
