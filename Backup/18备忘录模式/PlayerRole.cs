using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18备忘录模式
{
    class PlayerRole
    {
        public string Life { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }

        public StateMemento SaveState() 
        {
            return (new StateMemento(new PlayerRole() {Life=this.Life,Attack=this.Attack,Defense=this.Defense}));
        }

        public void RecoveryState(StateMemento m) 
        {
            this.Life = m.Life;
            this.Defense = m.Defense;
            this.Attack = m.Attack;
        }

        public void Boss() 
        {
            this.Attack = "0";
            this.Defense = "0";
            this.Life = "0";
        }

        public void ShowState() 
        {
            Console.WriteLine("生命力：{0}---攻击：{1}---防御{2}",Life,Attack,Defense);
        }
    }
}
