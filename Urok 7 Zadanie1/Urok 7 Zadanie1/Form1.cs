using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_7_Zadanie1
{
    public partial class Form1 : Form
    {
        double C, F;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawing()
        {
            int x0 = 50;
            int y0 = 10;
            double[] h = new double[2];
            h[0] = C;
            h[1] = F;
            float m = (float)1.65;
            float s = (float)F;
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);
            Brush brushBlue = Brushes.Blue;
            Brush brushRed = Brushes.Red;
            graph.DrawRectangle(penBlue, 50, 10, 50, 350);
            graph.DrawRectangle(penRed, 150, 10, 50, 350);
            graph.FillRectangle(brushBlue, x0, y0 + 350 - (float)h[0]* m, 50, (float)h[0]*m);
            graph.FillRectangle(brushRed, 150, y0 + 350 - (float)h[1] * m, 50, (float)h[1]*m);
            graph.DrawString(String.Format("{0:f2}", h[0]), new Font("Calibri", 12), Brushes.Black, 0, 330);
            graph.DrawString(String.Format("{0:f2}", h[1]), new Font("Calibri", 12), Brushes.Black, 200, 330);
            picture.Image = bmp;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Visible = true;
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Visible = true;
            button1.Visible = false;
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button3.Visible = true;
            button1.Visible = true;
            picture.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                C = double.Parse(textBox1.Text);
                if (C >= 0 && C <= 100)
                {
                    F = (C * 9 / 5) + 32;
                    drawing();
                }
                else
                {
                    textBox1.Text = "100";
                    C = 100;
                    F = 212;
                    drawing();
                }
            }
            catch
            {
                MessageBox.Show("Введите значения!!", "Ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (TB.Text.Length == 3 && TB.Text.Length <= 3)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                F = double.Parse(textBox2.Text);
                if (F >= 32 && F <= 212)
                {
                    C = (F - 32) * 5 / 9;
                    drawing();
                }
                else
                {
                    textBox2.Text = "212";
                    C = 100;
                    F = 212;
                    drawing();
                }
            }
            catch
            {
                MessageBox.Show("Введите значения!!", "Ошибка");
            }
        }
    }
}
