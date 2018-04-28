using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式.test
{
   public class Observer
    {
        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        IList<StockUser> list = new List<StockUser>();


       public void Attch(StockUser user) 
       {
           list.Add(user);
       }

       public void Notic() 
       {
           foreach (StockUser item in list)
           {
               item.Update();
           }
       }

    }
}
