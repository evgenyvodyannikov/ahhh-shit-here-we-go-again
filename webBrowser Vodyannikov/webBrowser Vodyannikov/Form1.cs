using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace webBrowser_Vodyannikov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://" + comboBox1.Text);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)13))
            {
                button4_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                listBox1.Items.Add(textBox1.Text + " | " + textBox2.Text);
                using (StreamWriter sw = new StreamWriter("web.txt"))
                {
                    sw.WriteLine(listBox1.Items.Count.ToString());
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите имя и адрес закладки");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button6.Visible = false;
            textBox2.Text = comboBox1.Text;
            listBox1.Items.Clear();
            using (StreamReader reader = new StreamReader("web.txt"))
            {
                string z = reader.ReadLine();
                for (int i = 0; i < Convert.ToDouble(z); i++ )
                {
                    listBox1.Items.Add(reader.ReadLine());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Нет выделенной строки");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            using (StreamWriter sw = new StreamWriter("web.txt"))
            {
                sw.WriteLine(listBox1.Items.Count.ToString());
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sw.WriteLine(listBox1.Items[i]);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            string newstr = "";
            int flag = 0;
            char c;
            int k = str.Length;
            for (int i = 0; i<k; i++)
            {
                c = str[i];
                if (flag != 0) newstr += c;
                if (c == '|') flag = 1;
            }
            comboBox1.Text = newstr;
        }
    }
}
