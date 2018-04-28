using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15抽象工厂模式.Test
{
    class AccessFactory:IFactory
    {

        #region IFactory 成员

        public IUser CreateUser()
        {
            return new AccessUser();
        }

        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        #endregion
    }
}
