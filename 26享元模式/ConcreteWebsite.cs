using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26享元模式
{
    class ConcreteWebsite:Website
    {
        string name;
        public ConcreteWebsite(string name) 
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类："+name+"用户:"+user.Name); ;
        }
    }
}
