using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18备忘录模式.test
{
    //发起者
    class Originator
    {
        string state;
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        public void GoToMemento(Memento m) 
        {
            this.state = m.State;
        }

        public void ShowState() 
        {
            Console.WriteLine(this.State);
        }
    }
}
