using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式
{
    //抽象观察者类
   abstract class Observer1
    {
        protected string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        protected Subject sub;

        //internal Subject Sub
        //{
        //    get { return sub; }
        //    set { sub = value; }
        //}

        public Observer1(string name, Subject sub) 
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }
}
