using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_Zadanie2
{
    public partial class Form1 : Form
    {
        int hh = 0;
        int mm = 0;
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            label2.Text = domainUpDown1.Text;
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            label3.Text = domainUpDown2.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            s = textBox1.Text;
            hh = int.Parse(label2.Text);
            mm = int.Parse(label3.Text);
            timer2.Start(); 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int hh1 = int.Parse(string.Format("{0}", DateTime.Now.ToString("HH")));
            int mm1 = int.Parse(string.Format("{0}", DateTime.Now.ToString("mm")));
            if (hh == hh1 && mm == mm1)
            {
                timer2.Stop();
                this.Show();
                MessageBox.Show("Пора вставать!! Напоминание: " + s, "Будильник!");
            }
        }
    }
}
