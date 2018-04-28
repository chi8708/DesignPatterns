using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19组合模式.test
{
    /// <summary>
    /// 枝节点
    /// </summary>
    class Composite:Component
    {
        public Composite(string name)
            : base(name) 
        {
        
        }

        List<Component> children = new List<Component>();

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-',Depth)+name);
            foreach (var item in children)
            {
                item.Display(Depth + 2);
            }
        }
    }
}
