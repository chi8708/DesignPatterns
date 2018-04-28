using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18备忘录模式.test
{
    //备忘录
    class Memento
    {
        public Memento(string state) 
        {
            this.State = state;
        }
        public string State { get; set; }
    }
}
