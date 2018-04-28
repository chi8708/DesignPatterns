using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19组合模式.test
{
   abstract class Component
    {
        protected string name;

        public Component(string name) 
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int Depth);

    }
}
