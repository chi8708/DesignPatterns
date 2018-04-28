using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式.test
{
   public class ConcertDecoratorA:Decorator
    {
        //本类特有功能
        private string addState;

        public override void Operation()
        {
            //首先执行原来Component的Operation();在运行自己的功能 如addStat;
            //相当于对原来Component做了装饰
            base.Operation();
            addState = "new";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}
