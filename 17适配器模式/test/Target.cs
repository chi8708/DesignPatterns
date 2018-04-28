using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    //客户所期待的接口
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通要求");
        }
    }
}
