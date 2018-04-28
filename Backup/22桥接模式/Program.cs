using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _22桥接模式.test;

namespace _22桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            HandeSoft a=new HanderSoftA();
            HandeSoft b=new HanderSoftB();

            HanderBrand h1 = new HanderBrandM("手机M");
            h1.SetSoft(a);
            h1.Run();

            HanderBrand h2 = new HanderBrandM("手机N");
            h2.SetSoft(a);
            h2.Run();
            h2.SetSoft(b);
            h2.Run();

            Console.ReadKey();
        }
    }
}
