using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
    public abstract  class Calculate
    {
       
       
        private double _num1=0;
        double _num2=0;

        public double Num1
        {
            get
            {
                return this._num1;
            }
            set
            {
                this._num1 = value;
            }

        }

        public double Num2
        {
            get
            {
                return this._num2;
            }
            set
            {
                this._num2 = value;
            }

        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
