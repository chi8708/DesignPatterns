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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolForm.GetCurrentInstance().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ToolForm.GetCurrentInstance().Show();
        }

    }
}
