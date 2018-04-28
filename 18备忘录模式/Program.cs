using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _18备忘录模式.test;
namespace _18备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Originator o = new Originator();
            //o.State = "ON";
            //o.ShowState();

            //Caretaker c = new Caretaker();
            //c.Memento=o.CreateMemento();

            //o.State = "Off";
            //o.ShowState();

            //o.GoToMemento(c.Memento);
            //o.ShowState();

            //Console.ReadKey();

            PlayerRole p = new PlayerRole();
            p.Attack = "100";
            p.Defense = "100";
            p.Life = "100";
            p.ShowState();

            MementoManager m = new MementoManager();
            m.StateMemento = p.SaveState();

            p.Boss();
            p.ShowState();

            p.RecoveryState(m.StateMemento);
            p.ShowState();
            Console.ReadKey();
        }
    }
}
