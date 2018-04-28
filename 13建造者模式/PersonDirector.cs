using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _13建造者模式
{
    class PersonDirector
    {
        PersonBulider pb;
        public PersonDirector(PersonBulider personBulider) 
        {
            pb = personBulider;
        }

        public void CreatePerSon()
        {
            pb.CreateHeader();
            pb.CreateBody();
            pb.CreateArmLeft();
            pb.CreateArmRight();
            pb.CreateLegLeft();
            pb.CreateLegRight();
        }
    }
}
