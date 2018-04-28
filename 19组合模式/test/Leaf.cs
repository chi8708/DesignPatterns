using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19组合模式.test
{
    //叶节点
    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("不能在叶节点添加子节点"); ;
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("不能在叶节点中移除子节点");
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-', Depth) + name);
        }
    }
}
