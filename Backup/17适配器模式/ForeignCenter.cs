using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace _17适配器模式
{
    public class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void 进攻()
        {
            Console.WriteLine("{0}中峰进攻", this.Name); ;
        }

        public void 防守()
        {
            Console.WriteLine("{1}中峰防守", this.Name);
             //DataAdapter ad = new DataAdapter();
            //ad.Fill(
            // SqlDataAdapter sad = new SqlDataAdapter();
            //sad.Fill()
        }

    }
}
