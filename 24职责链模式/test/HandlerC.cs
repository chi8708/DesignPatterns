using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24职责链模式.test
{
    class HandlerC:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 20 && request <= 30)
            {
                Console.WriteLine("{0}处理请求，处理时间:{1}", this.GetType().FullName, DateTime.Now);
            }
            else
            {
                if (handler != null)
                {
                    this.handler.HandleRequest(request);
                }

            }
        }
    }
}
