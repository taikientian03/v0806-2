using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806_2
{
    public partial class Form1 : Form
    {
        int vx = -20;
        int vy = -20;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            label1 Left=mp.X;
            label1 Left = mp.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
             label1.Left += vx;
            label1.Top += vy;

            if (label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Left + label1) ;
        }
    }
}
