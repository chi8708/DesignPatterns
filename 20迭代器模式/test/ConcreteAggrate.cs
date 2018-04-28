using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20迭代器模式.test
{
    //具体的聚集类
    class ConcreteAggrate:Aggreate
    {
        private IList<object> item = new List<object>();

        public override Iterator CreateIterator()
        {
           return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return item.Count; }
        }

        //索引器
        public object this[int index]
        {
            get { return item[index]; }
            set { item.Insert(index, value);}
        }
    }
}
