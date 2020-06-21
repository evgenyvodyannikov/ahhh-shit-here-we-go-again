using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yr5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            double a, b;
        int count;
        bool znak = true;
        float s;
        public void PP()
        {
            try
            {
                switch (count)
                {
                    case 1:
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString(Math.Round(b, 5));
                        label1.Text = "";
                        break;
                    case 2:
                        b = a - double.Parse(textBox1.Text);
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(Math.Round(b, 5));
                        break;
                    case 3:
                        b = a * double.Parse(textBox1.Text);
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(Math.Round(b, 5));
                        break;
                    case 4:
                        if (textBox1.Text == "0")
                        {
                            MessageBox.Show("Деление на нуль невозможно");
                        }
                        else
                        {
                            b = a / double.Parse(textBox1.Text);
                            label1.Text = "";
                            textBox1.Text = Convert.ToString(Math.Round(b, 5));
                        }
                        break;
                    case 5:
                        try { s = float.Parse(textBox1.Text); }
                        catch { MessageBox.Show("Не введено значение степени!!"); }
                        if (s < 0)
                        { MessageBox.Show("Подкоренное выражение меньше 0!!"); }
                        else
                        {
                            b = Math.Pow(a, 1 / s);
                            textBox1.Text = Convert.ToString(Math.Round(b, 5));
                            label1.Text = "";
                        }
                        break;
                    case 6:
                        try { s = float.Parse(textBox1.Text); }
                        catch { MessageBox.Show("Не введено значение степени!!"); }
                        b = Math.Pow(a, s);
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(Math.Round(b, 5));
                        break;
                    case 7:
                        b = Math.Sqrt(a);
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(Math.Round(b, 5));
                        break;
                    case 8:
                        b = Math.Pow(a, 2.0);
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(Math.Round(b, 5)); 
                        break;
                    case 9:
                        double f = 1;
                        for (int i = 1; i <= a; i++)
                            f *= (double)i;
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(Math.Round(f, 5));
                        break;

                    default:
                        break;
                }
            }
            catch
            {

            }
        }
        public void Slozenie()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                znak = true;
                label1.Text = a.ToString() + "+";
                }
                catch { }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }

        public void Minus()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 2;
                    label1.Text = a.ToString() + "-";
                    znak = true;
                }
                catch { }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }

        public void Delen()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
                }
                catch { }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }

        public void Umnoz()
        {
            if (label1.Text == "")
            {
                try 
                { 
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
            }
                catch { }
        }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }
        public void SqrtX()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                znak = true;
                label1.Text = "ⁿ√" + a.ToString();
            }
                catch { }
        }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }

        public void DegreeY()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 6;
                znak = true;
                label1.Text = a.ToString() + "ᵇ";
                }
                catch { }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }

        public void Sqrt()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 7;
                znak = true;
                label1.Text = "√" + a.ToString();
            }
                catch { }
        }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
        }

        public void Square()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 8;
                znak = true;
                label1.Text = a.ToString() + "²";
                }
                catch { }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }
           
        }

        public void Factorial()
        {
            if (label1.Text == "")
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 9;
                znak = true;
                label1.Text = a.ToString() + "!";
                }
                catch { }
        }
            else
            {
                if (textBox1.Text != "")
                {
                    PP();
                }
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Slozenie();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Minus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Umnoz();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Delen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else {
                        string st = textBox1.Text;
                        if (st.IndexOf(',') <= 0)
                        {
                            textBox1.Text += ",";
                        }
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i<lenght; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            (znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D0:
                    textBox1.Text += "0";
                    break;
                case Keys.D1:
                    textBox1.Text += "1";
                    break;
                case Keys.D2:
                    textBox1.Text += "2";
                    break;
                case Keys.D3:
                    textBox1.Text += "3";
                    break;
                case Keys.D4:
                    textBox1.Text += "4";
                    break;
                case Keys.D5:
                    textBox1.Text += "5";
                    break;
                case Keys.D6:
                    textBox1.Text += "6";
                    break;
                case Keys.D7:
                    textBox1.Text += "7";
                    break;
                case Keys.D8:
                    textBox1.Text += "8";
                    break;
                case Keys.D9:
                    textBox1.Text += "9";
                    break;
                case Keys.Back:
                    int lenght = textBox1.Text.Length - 1;
                    string text = textBox1.Text;
                    textBox1.Clear();
                    for (int i = 0; i < lenght; i++)
                    {
                        textBox1.Text += text[i];
                    }
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void инженерныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            this.Height = 510;
            groupBox1.Visible = true;
        }

        private void обычныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Width = 421;
            this.Height = 510;
            groupBox1.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SqrtX();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DegreeY();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Sqrt();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Square();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Factorial();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 421;
            this.Height = 510;
            groupBox1.Visible = false;
        }

        private void calculate()
        {
            PP();
        }

    }
}
