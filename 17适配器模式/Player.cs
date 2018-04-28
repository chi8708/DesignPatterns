using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    abstract class Player
    {
        public Player(string name) 
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract void Attack();

        public abstract void Defense(); 
    }
}
