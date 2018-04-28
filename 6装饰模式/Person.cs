using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式
{
   public class Person
    {
       private string name;

       public string Name 
       {
           get { return this.name; }
           set { this.name = value; }
       }

       public Person() { }

       public Person(string name) 
       {
           this.name = name;
       }

       public virtual void Show() 
       {
           Console.WriteLine("装扮{0}",name);
       }
    }
}
