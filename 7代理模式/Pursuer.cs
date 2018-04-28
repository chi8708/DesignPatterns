using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7代理模式
{
   public class Pursuer:Isend
    {
        #region Isend 成员

        public void SendFlower(SchoolGirl mm)
        {
            Console.WriteLine("送花"+mm.Name);
        }

        public void SendBall(SchoolGirl mm)
        {
            Console.WriteLine("送球" + mm.Name);
        }

        public void SendCholocate(SchoolGirl mm)
        {
            Console.WriteLine("送巧克力" + mm.Name);
        }

        #endregion
    }
}
