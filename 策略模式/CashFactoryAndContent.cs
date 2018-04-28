using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{

    /// <summary>
    /// 简单工厂 和策略模式共用
    /// </summary>
  public  class CashFactoryAndContent
    {
      CashSuper cs = null;

      public CashFactoryAndContent(string cashType) 
      {
         
          switch (cashType)
          {
              case "正常": cs = new CashNormal();
                  break;
              case "满三百返一百": cs = new CashReturn(300, 100);
                  break;
              case "打0.8折": cs = new CashDisCount(0.8);
                  break;
              default:
                  break;
          }
      
      }

      public double GetResult(double money) 
      {
          return cs.AcceptCash(money);
      }
    }
}
