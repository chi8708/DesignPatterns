using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
  public abstract  class CashSuper
    {
      /// <summary>
      /// 收取现金方法
      /// </summary>
      /// <param name="money">原价</param>
      /// <returns>打折或返还金额后的实价（应付）</returns>
    public  abstract double AcceptCash(double money);
    }
}
