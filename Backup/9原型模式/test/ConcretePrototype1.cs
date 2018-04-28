using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9原型模式.test
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id):base(id) 
        {
        
        }

        public override Prototype Clone()
        {
            //创建当当前对象的浅表复制
            return  (Prototype)this.MemberwiseClone();
        }
    }
}
