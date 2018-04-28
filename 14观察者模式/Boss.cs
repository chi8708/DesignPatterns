using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式
{
    class Boss:Subject
    {
        #region Subject 成员

        List<Observer1> list = new List<Observer1>();
        public void Attach(Observer1 obs)
        {
            list.Add(obs);
        }

        public void Delete(Observer1 obs)
        {
            list.Remove(obs);
        }

        public void Notity()
        {
            foreach (var item in list)
            {
                item.Update();
            }
        }

        private string action;
        public string Action
        {
            get
            {
                return this.action;
            }
            set
            {
                this.action = value;
            }
        }
        #endregion
    }
}
