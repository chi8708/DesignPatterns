using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    class Guard:Player
    {

        public Guard(string name)
            : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("{0}后卫进攻", base.Name); ;
        }

        public override void Defense()
        {
            Console.WriteLine("{0}后卫防守",base.Name);
        }
    }
}
