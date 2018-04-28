using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22桥接模式.test
{
    class HanderBrandN : HanderBrand
    {
        public HanderBrandN(string name)
            : base(name)
        {

        }

        public override void Run()
        {
            this.soft.Run();
        }
    }
}
