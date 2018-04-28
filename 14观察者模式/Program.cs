using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _14观察者模式.test;
using _14观察者模式.Even;

namespace _14观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Observer secretary = new Observer();
            //StockUser user1 = new StockUser("张三", secretary);
            //StockUser user2= new StockUser("李四", secretary);

            //secretary.Action = "老板回来啦！！！";
            //secretary.Attch(user1);
            //secretary.Attch(user2);
            //secretary.Notic();
            //Console.ReadKey(); 
            #endregion

            //观察者模式

            //Subject sub1 = new Boss();
            //sub1.Action = "Boss查房";
            //Subject sub2 = new Sercetary1();
            //sub2.Action = "秘书通知！";

            //Observer1 obs1 = new Observer1A("张三", sub1);
            //Observer1 obs2 = new Observer1A("李四", sub1);
            //Observer1 obs3 = new Observer1B("王五", sub2);
            //Observer1 obs4 = new Observer1B("赵六", sub2);

            //sub1.Attach(obs1);
            //sub1.Attach(obs2);
            //sub1.Delete(obs2);

            //sub2.Attach(obs3);
            //sub2.Attach(obs4);

            //sub1.Notity();
            //sub2.Notity();
            //Console.ReadKey();

           //事件委托实现
            BossEven sub1 = new BossEven();
            sub1.Action = "Boss查房";
            Observer1AEven obs1 = new Observer1AEven("李四", sub1);
            Observer1BEven obs3 = new Observer1BEven("王五", sub1);
            sub1.Update += obs1.SeeNBA;
            sub1.Update += new EvenHandler(obs3.SeeSotck);

            //EvenHandler dTest = obs3.SeeSotck;
            //dTest();

            sub1.Notity();
            Console.ReadKey();
            
            
        }

    }
}
