using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_zadanie1
{
    public partial class Form1 : Form
    {
        int s = 0;
        int m = 0;
        int s1 = 0;
        int m2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(button1.Focused == true)
            {
                s++;
                if(s == 59)
                {
                    m += 1;
                    s = 0;
                }
                label1.Text = m.ToString();
                label2.Text = s.ToString();
            }
            else
            {
                s1++;
                if (s1 == 59)
                {
                    m2 += 1;
                    s1 = 0;
                }
                label3.Text = m2.ToString();
                label4.Text = s1.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
