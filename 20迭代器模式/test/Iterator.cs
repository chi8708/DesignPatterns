using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20迭代器模式.test
{
    //迭代器抽象类
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object CurrentItem();
        public abstract bool IsDone();

        public void ddd()
        {
            Console.WriteLine("aaa");
        }

    }
}
