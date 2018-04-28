using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _9原型模式.test;

namespace _9原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //基本测试1
            //ConcretePrototype1 p1 = new ConcretePrototype1("iii");
            //ConcretePrototype1 c1= (ConcretePrototype1)p1.Clone();

            //Console.WriteLine("clone:\t"+c1.Id);
            //Console.ReadKey();


            //浅复制 对象的字段如果是值类型逐个复制，如果是引用类型复制引用不复制对象
            Resume r1 = new Resume("小样", 22, '男');//浅：Experience的引用是同一个对象
            r1.setExperience("xxx公司", "2012-2014");

            Resume r2 = (Resume)r1.Clone();
            r2.setExperience("xxxeee", "2014-20166");

            //深复制：把引用对象变量指向新的对象，而不是原有被应用的对象。
            Console.WriteLine("很深很深复制");
            Resume r3 = (Resume)r1.DeepClone();
            r3.setExperience("xxxeee3", "2014-20166");

            r1.Show();
            r2.Show();
            r3.Show();

            Console.ReadKey();
        }
    }
}
