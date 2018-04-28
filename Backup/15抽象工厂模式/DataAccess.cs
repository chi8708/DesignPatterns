using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace _15抽象工厂模式
{
    //简单工厂
    class DataAccess
    {
       // private readonly string dbType = "SqlServer";
        private readonly string dbType = ConfigurationManager.AppSettings["DB"];

        //利用反射代替switch语句
        private readonly string assemblyName = "15抽象工厂模式";

        public IUser CreateUser()
        {
            IUser user = null;
            //switch (dbType)
            //{
            //    case "SqlServer": user=new SqlServerUser();
            //        break;
            //    case "Access": user = new AccessUser();
            //        break;
            //    default:
            //        break;
            //}
            //利用反射代替switch语句
            string className = "_15抽象工厂模式." + dbType + "User";
            user = (IUser)Assembly.Load(assemblyName).CreateInstance(className);
            return user;
        }

        public IDepartment CreateDepartment()
        {
            IDepartment department = null;

            switch (dbType)
            {
                case "SqlServer": department = new SqlServerDepartment();
                    break;
                case "Access": department = new AccessDepartment();
                    break;
                default:
                    break;
            }

            return department;
        }
    }
}
