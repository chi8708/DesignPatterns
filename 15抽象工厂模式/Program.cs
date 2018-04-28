using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _15抽象工厂模式.Test;

namespace _15抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //抽象工厂实现方式
            User userModel = new User { Name = "zhangsan" };
            IUser user = null;
            IFactory factory = new AccessFactory();
            user = factory.CreateUser();

            user.AddUser(userModel);

            //简单工厂实现方式
            DataAccess dataAccess = new DataAccess();
            IDepartment department = dataAccess.CreateDepartment();
            department.AddDepartment(new Department() { Name = "hahah", Remark = "测试" });

            //简单工厂的switch 替换为反射

            IUser Iuser2 = dataAccess.CreateUser();
            Iuser2.GetSingleUser(userModel);

            IUser iuser = null;
            SqlServerUser user3 = new SqlServerUser();
            iuser = (IUser)user3;

            Console.ReadKey();
        }
    }
}
