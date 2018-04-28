using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
    class IDivFactory:IoperateFactory
    {
        #region IoperateFactory 成员

        public Calculate CreateOperate()
        {
            return new Div();
        }

        #endregion
    }
}
