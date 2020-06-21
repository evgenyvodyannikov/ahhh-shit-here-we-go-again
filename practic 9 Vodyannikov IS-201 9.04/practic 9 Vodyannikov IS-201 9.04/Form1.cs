using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic_9_Vodyannikov_IS_201_9._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) groupBox1.Visible = true;
            else groupBox1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { label2.Visible = true; textBox1.Visible = true; }
            else { label2.Visible = false; textBox1.Visible = false; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text;
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            Random G;
            string str;
            if (checkBox1.Checked == false) G = new Random(); else
            {
                int n;
                try
                {
                    n = Convert.ToInt32(textBox1.Text);
                }
                catch { n = 0; }
                G = new Random(n);
            }
            for (int n = 0; n < 10; n++)
            {
                if (checkBox2.Checked == false)
                {
                    double d = G.NextDouble();
                    str = Convert.ToString(Math.Round(d, 2));
                    listBox1.Items.Add(str);
                }
                else
                {
                    int m = 0;
                    if (radioButton1.Checked == true)
                    {
                        m = G.Next();
                    }
                    if (radioButton2.Checked == true)
                    {
                        int max;
                        try
                        {
                            max = Convert.ToInt32(textBox3.Text);
                        }
                        catch
                        { max = 100; }
                        m = G.Next(max);
                    }
                    if (radioButton3.Checked == true)
                    {
                        int min, max;
                        try
                        {
                            min = Convert.ToInt32(textBox2.Text);
                            max = Convert.ToInt32(textBox3.Text);
                        }
                        catch
                        { max = 100; min = 0; }
                        m = G.Next(min, max);
                    }
                    listBox1.Items.Add(m.ToString());
                }
            }
            int i; double s = 0; double r = 0;
            for (i = 0; i < 10; i++)
            {
                s = Convert.ToDouble(listBox1.Items[i]);
                switch (comboBox1.SelectedIndex)
                {
                    case 0: r = Math.Atan(s); break;
                    case 1: r = Math.Cos(s); break;
                    case 2: r = Math.Exp(s); break;
                    case 3: r = Math.Log(s); break;
                    case 4: r = Math.Sin(s); break;
                    case 5: r = Math.Tan(s); break;
                    case 6: r = Math.Floor(s); break;
                    case 7: r = Math.Ceiling(s); break;
                    case 8: r = Math.Pow(s, 3); break;
                    case 9: r = Math.Sqrt(s); break;
                }
                str = Convert.ToString(Math.Round(r, 4));
                listBox2.Items.Add(str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}

                
        