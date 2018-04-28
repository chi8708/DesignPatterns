using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Action vistor1 = new FailAction();
            Action vistor2 = new SuccessAction();

            Person m = new Man();
            Person wm = new Woman();

            //由于总是希望男人和女人在不同状态下对比，所以使用ObjectStruct对不同状态遍历，得到不同反应
            ObjectStruct o = new ObjectStruct();
            o.Add(m);
            o.Display(vistor1);
            o.Add(wm);
            o.Display(vistor2);

            //不通过ObjectStruct进行访问
            m.Action(vistor1);

            Console.ReadKey();

        }
    }
}
