using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    //正常收费子类
   public class CashNormal:CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
