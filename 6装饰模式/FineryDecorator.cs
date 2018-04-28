using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6装饰模式
{
    public class FineryDecorator:Person
    {
      
        protected Person p;
        //创建具体的对象
        public void Decorator(Person p) 
        {
            this.p = p;
        }

        public override void Show()
        {
            if (p!=null)
            {
                p.Show();
            }
        }
    }
}
