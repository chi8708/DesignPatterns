using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7代理模式
{
    class Agent:Isend
    {
        #region Isend 成员
       Pursuer p = null;
       public Agent() 
       {
           if (p==null)
           {
               p = new Pursuer();
           }
       }

        public void SendFlower(SchoolGirl mm)
        {
            p.SendFlower(mm);
        }

        public void SendBall(SchoolGirl mm)
        {
            p.SendBall(mm);
        }

        public void SendCholocate(SchoolGirl mm)
        {
            p.SendCholocate(mm);
        }

        #endregion
    }
}
