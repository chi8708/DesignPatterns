using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13建造者模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red);
           // Graphics g = pictureBox1.CreateGraphics();
           // g.DrawEllipse(p, 50, 20, 30, 30);
            //e.Graphics.DrawEllipse(p, 50, 30, 30, 30);
            //e.Graphics.DrawRectangle(p, 50, 60, 30, 50);
            //e.Graphics.DrawLine(p, 50, 60, 30, 100);
            //e.Graphics.DrawLine(p, 80, 60, 100, 100);
            //e.Graphics.DrawLine(p, 60, 110, 40, 130);
            //e.Graphics.DrawLine(p, 70, 110, 90, 130);


            //e.Graphics.DrawEllipse(p, 130, 30, 30, 30);
            //e.Graphics.DrawRectangle(p, 130, 60, 50, 50);
            //e.Graphics.DrawLine(p, 130, 60, 90, 100);
            //e.Graphics.DrawLine(p, 160, 60, 190, 100);
            //e.Graphics.DrawLine(p, 140, 110, 120, 130);
            //e.Graphics.DrawLine(p, 150, 110, 170, 130);

            PersonBulider person1 = new ThinPerSon(p, e.Graphics);
            PersonBulider person2 = new FatPerson(p, e.Graphics);

            PersonDirector director1 = new PersonDirector(person1);
            PersonDirector director2 = new PersonDirector(person2);

            director1.CreatePerSon();
            director2.CreatePerSon();
            
        }


    }
}
