using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
    class IMulFactory:IoperateFactory
    {
        #region IoperateFactory 成员

        public Calculate CreateOperate()
        {
            return new Mul();
        }

        #endregion
    }
}
