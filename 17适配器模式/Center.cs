using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    class Center:Player
    {
        public Center(string name)
            : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("{0}中峰进攻", this.Name); ;
        }

        public override void Defense()
        {
            Console.WriteLine("{1}中峰防守",this.Name);
        }
    }
}
