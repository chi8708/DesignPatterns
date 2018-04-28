using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20迭代器模式.test
{
    //反序迭代器
    class ConcreteIteratorDESC:Iterator
    {
         private ConcreteAggrate aggrate;
        int current = 0;

        public ConcreteIteratorDESC(ConcreteAggrate aggrate) 
        {
            this.aggrate = aggrate;
            current = aggrate.Count;
        }

        public override object First()
        {
           return aggrate[current-1];
        }

        public override object Next()
        {
            object o = null;
            current--;
            if (current<aggrate.Count)
            {
                o = aggrate[current];
            }

            return o;
        }

        public override object CurrentItem()
        {
            return aggrate[current-1];
        }

        public override bool IsDone()
        {
            return current<=0?true:false;
        }
    }
}
