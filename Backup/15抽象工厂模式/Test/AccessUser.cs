using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15抽象工厂模式
{
    class AccessUser:IUser
    {
        public void AddUser(User u)
        {
            Console.WriteLine("向Access中添加一条用户信息");
        }

        public void GetSingleUser(User u)
        {
            Console.WriteLine("向Access中查询一条用户详细信息"); ;
        }

    }
}
