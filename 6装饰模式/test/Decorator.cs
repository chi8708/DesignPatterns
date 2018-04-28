using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式.test
{
    //装饰类,从外类来扩展Component类的功能
   public class Decorator:Component
    {
       public Component component;

       public void SetComponent(Component coponent) 
       {
           this.component = coponent;
       }

       //重写Operation 实际执行Component的Operation()
        public override void Operation()
        {
            if (component!=null)
            {
                component.Operation();
            }
        }
    }
}
