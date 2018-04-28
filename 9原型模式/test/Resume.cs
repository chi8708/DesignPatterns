using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _9原型模式.test;

namespace _9原型模式
{
    public class Resume : ICloneable
    {
        private WorkExperience work;

        public Resume(string name,int age,char gender)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;

            this.work = new WorkExperience();
        }

        //私有构造函数
        private Resume(WorkExperience work) 
        {
            //深复制
           this.work =(WorkExperience) work.Clone();
        }

        public string name;
        public int age;
        public char gender;
        public string company;
        public string areaTime;
        

        public void setExperience(string c, string at)
        {
            //this.company = c;
            //this.areaTime = at;

            work.AreaDate = at;
            work.Company = c;

        }


        public void Show() 
        {
            Console.WriteLine("{0}\t{1}\t{2}",this.name,this.age,this.gender);
            //Console.WriteLine("{0} {1}",this.company,this.areaTime);
            Console.WriteLine("{0} {1}", work.Company, work.AreaDate);
        }

        #region ICloneable 成员

        public object Clone()
        {
            //浅复制
            return this.MemberwiseClone();
        }

        /// <summary>
        /// 深复制
        /// </summary>
        /// <returns></returns>
        public object DeepClone() 
        {
            Resume rs = new Resume(this.work);
            rs.name = this.name;
            rs.age = this.age;
            rs.gender = this.gender;

            return rs;

        }
        #endregion
    }
}
