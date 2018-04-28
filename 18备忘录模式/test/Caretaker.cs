using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18备忘录模式.test
{
    //管理者
    class Caretaker
    {
        Memento m;
        public Memento Memento 
        {
            get { return m; }
            set { this.m=value; }
        }
    }
}
