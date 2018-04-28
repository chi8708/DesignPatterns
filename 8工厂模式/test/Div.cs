using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
    public class Div:Calculate
    {
        public override double GetResult()
        {
            double result = 0;
            if (Num2==0)
            {
                throw new Exception("除数不能为0");

            }
            else
            {
                result = Num1 / Num2;
            }

            return result;
        }
    }
}
