using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 策略模式上下文
    /// </summary>
   public class CashContent
    {
       CashSuper cs = null;

       /// <summary>
       /// 初始化传入策略对象
       /// </summary>
       /// <param name="cs"></param>
       public CashContent(CashSuper cs) 
       {
           this.cs = cs;
       }

       /// <summary>
       ///根据策略对象 得到具体的算法
       /// </summary>
       /// <returns></returns>
       public double GetResult(double money) 
       {
           return cs.AcceptCash(money);
       }
    }
}
