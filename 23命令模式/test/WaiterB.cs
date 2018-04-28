using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23命令模式.test
{
    //waiter太不给力了，一个订单要通知一声，WaiterB订单一起通知；
    class WaiterB
    {
       List<Command> cmList=new List<Command>();

       public void AddOrder(Command command) 
       {
           cmList.Add(command);
           string s = string.Format("增加订单：{0}--{1}", command.ToString(), DateTime.Now);
           Console.WriteLine(s);
       }

       public void CancleOrder(Command command)
       {
           cmList.Remove(command);
           string s = string.Format("取消订单：{0}--{1}", command.ToString(), DateTime.Now);
           Console.WriteLine(s);
       }

        public void Notice()
        {
            foreach (Command item in cmList)
            {
                item.Bake();
            }
           // cm.Bake();
        }
    }
}
