using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    public class CashFactory
    {

        public static CashSuper CreatCash(string cashSort)
        {
            CashSuper cs = null;
            switch (cashSort)
            {
                case "正常": cs = new CashNormal();
                    break;
                case "满三百返一百": cs = new CashReturn(300,100);
                    break;
                case "打0.8折": cs = new CashDisCount(0.8);
                    break;
            }
            return cs;
        }
    }
}
