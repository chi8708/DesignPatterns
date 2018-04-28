using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    class Adaptee
    {
        //需要适配的类
        public void SpecialRequest() 
        {
            Console.WriteLine("特殊要求");
        }
    }
}
