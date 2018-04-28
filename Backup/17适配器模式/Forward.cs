using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    class Forward : Player
    {
        public Forward(string name)
            : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("{0}前峰进攻", this.Name); ;
        }

        public override void Defense()
        {
            Console.WriteLine("{1}前峰防守",base.Name);
        }
    }
}
