using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9原型模式.test
{
    public class WorkExperience : ICloneable
    {
        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        private string areaDate;

        public string AreaDate
        {
            get { return areaDate; }
            set { areaDate = value; }
        }



        #region ICloneable 成员

        public  object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
