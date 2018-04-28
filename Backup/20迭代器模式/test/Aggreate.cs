using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20迭代器模式.test
{
    //抽象聚集类
    abstract class Aggreate
    {
        //创建迭代器
        public abstract Iterator CreateIterator();
    }
}
