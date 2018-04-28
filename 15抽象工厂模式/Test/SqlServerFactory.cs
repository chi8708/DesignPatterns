using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15抽象工厂模式
{
    class SqlServerFactory:IFactory
    {
        #region IFactory 成员

        public IUser CreateUser()
        {
           return new SqlServerUser();
        }

        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        #endregion
    }
}
