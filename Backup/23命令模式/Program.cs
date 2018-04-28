using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _23命令模式.test;

namespace _23命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Reciver r1 = new Reciver();
            //Waiter w1 = new Waiter();

            //Command c1 = new CommandBakeChickenWing(r1);
            //w1.SetOrder(c1);
            //w1.Notice();

            //Command c2 = new CommandBakeSheep(r1);
            //w1.SetOrder(c2);
            //w1.Notice();
            //Console.ReadKey();

            //2.多个订单一起通知
            WaiterB w2 = new WaiterB();
            Command c1 = new CommandBakeChickenWing(r1);
            Command c2 = new CommandBakeSheep(r1);
            w2.AddOrder(c1);
            w2.AddOrder(c2);
            w2.CancleOrder(c1);
            w2.Notice();
            Console.ReadKey();


        }
    }
}
