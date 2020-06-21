using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer1
{
    public partial class Form1 : Form
    {
        public
        int h = 0;
        int m = 0;
        int s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {h = int.Parse(textBox1.Text);
                
            }
            catch { h = 0; }
            try
            {   m = int.Parse(textBox2.Text);
               
            }
            catch { m = 0; }
            try { s = int.Parse(textBox3.Text); s += 1;
               
            }
            catch { s = 0; }
            Timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (h > 24)
            { Timer.Stop(); MessageBox.Show("Кол-во часов не может быть больше 24!!"); }
            else
            {
                if (m > 60)
                { Timer.Stop();  MessageBox.Show("Кол-во минут не может быть больше 60!!");  }
                else
                {
                    if (s > 60)
                    { Timer.Stop(); MessageBox.Show("Кол-во секунд не может быть больше 60!!"); }
                    else
                    {
                        s--;
                        if (h == 0 & m == 0 & s == 0)
                        {
                            Timer.Stop();
                            MessageBox.Show("Время вышло!");
                            lbTimer.Text = "0";
                            label2.Text = "0";
                            label3.Text = "0";
                        }
                        if (s <= 0)
                        {
                            if (m > 0)
                            {
                                m--;
                                s = 59;
                            }
                        }
                        lbTimer.Text = Convert.ToString(h);
                        label2.Text = Convert.ToString(m);
                        label3.Text = Convert.ToString(s);
                        if (m < 1)
                        {
                            if (h > 0)
                            {
                                h = h - 1;
                                m = 59;
                            }
                        }
                    }
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Timer.Stop();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lbTimer.Text = "0";
            label2.Text = "0";
            label3.Text = "0";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 2 && textBox1.Text.Length <= 2)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox2.Text.Length == 2 && textBox2.Text.Length <= 2)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox3.Text.Length == 2 && textBox3.Text.Length <= 2)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
    }
}
