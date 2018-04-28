using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15抽象工厂模式
{
    class SqlServerUser:IUser
    {
        #region IUser 成员

        public void AddUser(User u)
        {
            Console.WriteLine("向sqlserver中添加一条用户信息");
        }

        public void GetSingleUser(User u)
        {
            Console.WriteLine("向sqlserver中查询一条用户详细信息"); ;
        }

        #endregion
    }
}
