using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24职责链模式.test
{
   abstract class Handler
    {
       protected Handler handler;

       //设置继承者
       public void setHandler(Handler h) 
       {
           this.handler = h;
       }

       public abstract void HandleRequest(int request); 
    }
}
