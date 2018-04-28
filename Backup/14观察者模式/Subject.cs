using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14观察者模式
{
    //通知者接口
    interface Subject
    {
        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="sub"></param>
        void Attach(Observer1 observer);

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="sub"></param>
        void Delete(Observer1 observer);

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
