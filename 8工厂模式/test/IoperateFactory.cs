using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
    interface IoperateFactory 
    {
       Calculate CreateOperate();
    }
}
