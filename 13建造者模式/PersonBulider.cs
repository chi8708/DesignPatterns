using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _13建造者模式
{
   public abstract class PersonBulider
    {
      protected Pen p;
      internal Graphics g;
       public PersonBulider(Pen p, Graphics g) 
       {
           this.p = p;
           this.g = g;
       }

       public abstract void CreateHeader();
       public abstract void CreateBody();
       public abstract void CreateArmLeft();
       public abstract void CreateArmRight();
       public abstract void CreateLegLeft();
       public abstract void CreateLegRight();

    }
}
