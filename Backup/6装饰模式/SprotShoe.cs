using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式
{
   public class SprotShoe:FineryDecorator
    {
        public override void Show()
        {
            Console.WriteLine("运动鞋！！");
            base.Show();
        }
    }
}
