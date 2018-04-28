using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _13建造者模式
{
    class ThinPerSon:PersonBulider
    {
        public ThinPerSon(Pen p, Graphics g) : base(p, g) 
        {
        
        }

        public override void CreateHeader()
        {
           g.DrawEllipse(p, 50, 30, 30, 30);
        }

        public override void CreateBody()
        {
            g.DrawRectangle(p, 50, 60, 30, 50);
        }

        public override void CreateArmLeft()
        {
            g.DrawLine(p, 50, 60, 30, 100);
        }

        public override void CreateArmRight()
        {
            g.DrawLine(p, 80, 60, 100, 100);
        }

        public override void CreateLegLeft()
        {
            g.DrawLine(p, 60, 110, 40, 130);
        }

        public override void CreateLegRight()
        {
            g.DrawLine(p, 70, 110, 90, 130);
        }
    }
}
