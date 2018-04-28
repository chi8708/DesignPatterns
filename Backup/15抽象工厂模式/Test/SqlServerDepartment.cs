using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _15抽象工厂模式.Test;

namespace _15抽象工厂模式
{
    class SqlServerDepartment:IDepartment
    {
        #region IDepartment 成员

        public void AddDepartment(Department d)
        {
            Console.WriteLine("向sqlserver中添加一条部门信息");
        }

        public void GetSignalDepartment(Department d)
        {
            Console.WriteLine("从sqlserver中查询一条部门详细信息");
        }

        #endregion
    }
}
