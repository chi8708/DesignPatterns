using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28访问者模式
{
    class SuccessAction:Action
    {
        public override void GetManAction(Man m)
        {
            Console.WriteLine(m.GetType().FullName.ToString() + "成功反应") ;
        }

        public override void GetWomanAction(Woman wm)
        {
            Console.WriteLine(wm.GetType().FullName.ToString() + "成功反应");
        }
    }
}
