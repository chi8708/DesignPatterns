using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26享元模式
{
   public class User
    {
        public User(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
