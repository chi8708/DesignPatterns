using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17适配器模式
{
    /// <summary>
    /// 适配器 把源接口转为目标接口
    /// </summary>
    class Adapter:Target
    {
        Adaptee a = new Adaptee();

        public virtual void Request()
        {
            a.SpecialRequest();
        }

    }
}
