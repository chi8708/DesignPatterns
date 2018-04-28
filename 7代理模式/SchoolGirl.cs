using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7代理模式
{
   public class SchoolGirl
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SchoolGirl(string name) 
        {
            this.name = name;
        }
    }
}
