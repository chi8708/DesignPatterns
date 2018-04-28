using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _13建造者模式
{
    class FatPerson:PersonBulider
    {
        public FatPerson(Pen p, Graphics g):base(p,g) 
        {
        
        }

        public override void CreateHeader()
        {
           g.DrawEllipse(p, 130, 30, 30, 30);
        }

        public override void CreateBody()
        {
            g.DrawRectangle(p, 130, 60, 50, 50);
        }

        public override void CreateArmLeft()
        {
           g.DrawLine(p, 130, 60, 90, 100);
        }

        public override void CreateArmRight()
        {
            g.DrawLine(p, 160, 60, 190, 100);
        }

        public override void CreateLegLeft()
        {
          g.DrawLine(p, 140, 110, 120, 130);
        }

        public override void CreateLegRight()
        {
            g.DrawLine(p, 150, 110, 170, 130);
        }
    }
}
