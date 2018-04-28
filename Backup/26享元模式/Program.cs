using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f=new WebSiteFactory();

            User user1 = new User("小菜");
            Website wb1 = f.GetWebSiteCategory("产品展示");

            User user2 = new User("小菜");
            Website wb2 = f.GetWebSiteCategory("论坛");

            User user3 = new User("大鸟");
            Website wb3= f.GetWebSiteCategory("产品展示");

            User user4= new User("大鸟");
            Website wb4 = f.GetWebSiteCategory("论坛");

            wb1.Use(user1);
            wb1.Use(user2);
            wb1.Use(user3);
            wb1.Use(user4);
            //通过工厂只创建了两个实例
            Console.WriteLine(f.GetWebSiteCount());

            Console.ReadKey();
        }
    }
}
