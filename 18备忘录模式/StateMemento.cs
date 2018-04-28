using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18备忘录模式
{
    class StateMemento
    {
        public StateMemento(PlayerRole p) 
        {
            this.Life = p.Life;
            this.Attack = p.Attack;
            this.Defense = p.Defense;
        }
        public string Life { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }
    }
}
