using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
   public class CashReturn:CashSuper
    {
       double condMoney = 0;
       double returnMoney = 0;
       /// <summary>
       /// 构造函数
       /// </summary>
       /// <param name="condMoney">条件</param>
       /// <param name="retrunMoney">返回</param>
       public CashReturn(double condMoney, double returnMoney) 
       {
           this.condMoney = condMoney;
           this.returnMoney = returnMoney;
       } 


        public override double AcceptCash(double money)
        {
            double result = 0;
            if (money>=condMoney)
            {
                result = money -Math.Ceiling(money / condMoney) * returnMoney;
              
            }
            else
            {
                result = money;
            }
            return result;
        }
    }
}
