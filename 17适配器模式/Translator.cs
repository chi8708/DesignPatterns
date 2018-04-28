using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    //适配器
    class Translator:Player
    {
      

        private ForeignCenter fc = new ForeignCenter();
        public Translator(string name)
            : base(name)
        {
            fc.Name =base.Name;
        }

        public override void Attack()
        {
            fc.进攻();
        }

        public override void Defense()
        {
           fc.防守();
        }
    }
}
