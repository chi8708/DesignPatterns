using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式.test
{
    //定义对象接口 可以给这些对象动态添加职责
   public abstract class Component
    {
       public abstract void Operation();
    }
}
