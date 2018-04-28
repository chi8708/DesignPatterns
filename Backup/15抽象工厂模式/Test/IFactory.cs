using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15抽象工厂模式
{
    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
