using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _6装饰模式.test;

namespace _6装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //test装饰模式
            ConcreteComponent c = new ConcreteComponent();
            ConcertDecoratorA a = new ConcertDecoratorA();
            ConcertDecoratorB b = new ConcertDecoratorB();

            //先用ConcreteComponent实例化对象c,
            //在用ConcertDecoratorA实例化对象a来包装c，
            //在用ConcertDecoratorB实例化对象b来包装a，
            //最终执行b的Operation();
            a.SetComponent(c);
            b.SetComponent(a);
            b.Operation();
           

            //总结： 通过ConecreteCompenent对象的一个方法对对象进行包装，
            //这样每个装饰对象的实现（实例化）和如何使用这个对象（方法、字段、属性等行为）分开了，
            //每个装饰对象只关心自己的功能，不必关心如何被加入到对象链中。

            //Person p1 = new Person("小样");
            // BigTrouse t = new BigTrouse();
            //SprotShoe s = new SprotShoe();

            //t.Decorator(p1);
            //s.Decorator(t);
            //s.Show();

            Person p2 = new Person("大洋");
            BigTrouse t = new BigTrouse();
            BadShoe b1 = new BadShoe();
            b1.Decorator(p2);
            t.Decorator(b1);
            t.Show();
            Console.ReadLine();

        }
    }
}
