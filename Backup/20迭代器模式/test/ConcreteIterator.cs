using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20迭代器模式.test
{
    //迭代器实现
    class ConcreteIterator:Iterator
    {
        private ConcreteAggrate aggrate;
        int current = 0;

        public ConcreteIterator(ConcreteAggrate aggrate) 
        {
            this.aggrate = aggrate;
        }

        public override object First()
        {
           return aggrate[0];
        }

        public override object Next()
        {
            object o = null;
            current++;
            if (current<aggrate.Count)
            {
                o = aggrate[current];
            }

            return o;
        }

        public override object CurrentItem()
        {
            return aggrate[current];
        }

        public override bool IsDone()
        {
            return current>=aggrate.Count?true:false;
        }
    }
}
