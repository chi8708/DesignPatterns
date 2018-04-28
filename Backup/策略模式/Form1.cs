using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 策略模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double tolalPrice = 0;
        private void btnCal_Click(object sender, EventArgs e)
        {
            
            int count = int.Parse(txtCount.Text);
           double price = double.Parse(txtPrice.Text);

           //1.简单工厂模式的实现
           // CashSuper cs = CashFactory.CreatCash(cbStyle.SelectedItem.ToString());
           // double onePrice= cs.AcceptCash(count * price);
           

           // 2策略模式实现
            //string type = cbStyle.SelectedItem.ToString();
            //CashContent content = null;
            //switch (type)
            //{
            //    case "正常":content=new CashContent(new CashNormal());
            //        break;
            //    case "满三百返一百":content=new CashContent(new CashReturn(300,100));
            //        break;
            //    case "打0.8折":content=new CashContent(new CashDisCount(0.8));
            //        break;
            //}
           //double onePrice= content.GetResult(count*price);

           //3简单工厂模式和策略模式公用
           CashFactoryAndContent cs = new CashFactoryAndContent(cbStyle.SelectedItem.ToString());
           double onePrice = cs.GetResult(count * price);
           tolalPrice += onePrice;

           string info = string.Format("数量为:{0}  单价为:{1}  {3} 小计:{2}", count, price, onePrice, cbStyle.SelectedItem);
           lbAllInfo.Items.Add(info);

           lbTotalPrice.Text = tolalPrice.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbStyle.Items.AddRange(new string[] {"正常","满三百返一百","打0.8折"});

            cbStyle.SelectedIndex = 0;
           
        }


    }
}
