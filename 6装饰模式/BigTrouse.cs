using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式
{
  public class BigTrouse:FineryDecorator
    {
        public override void Show()
        {
            Console.WriteLine("大裤衩！！");
            base.Show();
        }
    }
       
}
