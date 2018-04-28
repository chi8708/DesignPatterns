using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式.test
{
   public class StockUser
    {
       private string name;
       private Observer secretary;

       public StockUser(string name,Observer st) 
       {
           this.name = name;
           this.secretary = st;
       }

       public void Update() 
       {
           Console.WriteLine("{0}{1}继续工作!!",secretary.Action,this.name);
       }
    }
}
