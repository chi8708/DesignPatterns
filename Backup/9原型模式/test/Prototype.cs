using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9原型模式.test
{
   public abstract class Prototype
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Prototype(string id) 
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
