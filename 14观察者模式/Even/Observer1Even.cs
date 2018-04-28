using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _14观察者模式.Even;

namespace _14观察者模式
{
    //抽象观察者类
   abstract class Observer1Even
    {
        protected string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        protected SubjectEven sub;

        //internal Subject Sub
        //{
        //    get { return sub; }
        //    set { sub = value; }
        //}

        public Observer1Even(string name, SubjectEven sub) 
        {
            this.name = name;
            this.sub = sub;
        }

        //public abstract void Update();
    }
}
