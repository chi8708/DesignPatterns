using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22桥接模式.test
{
   abstract class HanderBrand
    {
       protected string Name { get; set; }
       protected HanderBrand(string name) 
       {
           this.Name = name;
           Console.WriteLine(this.Name);
       }

       protected HandeSoft soft;

       public void SetSoft(HandeSoft s) 
       {
           this.soft = s;
       }

      public abstract void Run();
    }
}
