using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21单例模式
{
    public partial class ToolForm : Form
    {
        //public ToolForm()
        //{
        //    InitializeComponent();
        //}

        private ToolForm() 
        {
            InitializeComponent();
        }
        private static readonly object syncObject = new object();
        private static ToolForm tf = null;
        //懒汉式，假如是饿汉式直接调用GetCurrentInstance返回全局静态实例（第一次调用类成员时创建，其他时候均不创建）
        //private static ToolForm tfstatic = new ToolForm();占用启动资源
        public static ToolForm GetCurrentInstance() 
        {
            //假如是多线程同时访问该类，同时调用GetCurrentInstance方法时，可能出现创建多个实例
            if (tf == null || tf.IsDisposed)
            {
                //双重加锁
                lock (syncObject)
                {
                    if (tf == null || tf.IsDisposed)
                    {
                        tf = new ToolForm();
                        tf.MdiParent = Form1.ActiveForm;
                    }
                }
            }
           
            return tf;
        }
    }
}
