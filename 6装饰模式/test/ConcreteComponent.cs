using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式.test
{

    //定义一个具体的对象 也可给这个对象动态的添加一些职责
  public  class ConcreteComponent:Component
    {
      public override void Operation()
      {
          Console.WriteLine("具体对象的操作"); ;
      }
    }
}
