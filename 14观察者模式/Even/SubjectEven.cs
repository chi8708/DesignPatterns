using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式.Even
{
    /// <summary>
    /// 通过事件委托来实现
    /// </summary>
    public delegate void EvenHandler();
        //通知者接口
        interface SubjectEven
        {
            /// <summary>
            /// 通知观察者
            /// </summary>
            void Notity();

            /// <summary>
            /// 状态
            /// </summary>
            string Action { get; set; }
        }
  
}
