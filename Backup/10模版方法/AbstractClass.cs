using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10模版方法
{
   abstract class AbstractClass
    {
       /// <summary>
       /// 一些抽象方法让子类去实现
       /// </summary>
       public abstract void PrimitiveOperation1();
       public abstract void PrimitiveOperation2();

       /// <summary>
       /// 模版方法
       /// </summary>
       public void TemplateMethod()
       {
           PrimitiveOperation1();
           PrimitiveOperation2();
           Console.WriteLine("");
       }

    }
}
