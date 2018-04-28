using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式.Even
{
    //秘书类类似
    class BossEven:SubjectEven
    {
      public event EvenHandler Update;
        #region SubjectEven 成员

        public void Notity()
        {
            Update();
        }

        private string action;
        public string Action
        {
            get
            {
                return this.action;
            }
            set
            {
                this.action = value;
            }
        }

        #endregion
    }
}
