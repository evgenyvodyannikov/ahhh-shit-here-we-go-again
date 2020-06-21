using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_11_Водянников_Задание_4_6
{
    public partial class Zadanie2 : Form
    {
        Bitmap pic;
        Bitmap pic1;
        public Zadanie2()
        {
            InitializeComponent();
            pic = new Bitmap(1000, 1000);
            pic1 = new Bitmap(1000, 1000);
            SolidBrush b = new SolidBrush(Color.White);
            Graphics.FromImage(pic).FillRectangle(b, 0, 0, pic.Width, pic.Height);
            Graphics.FromImage(pic1).FillRectangle(b, 0, 0, pic1.Width, pic1.Height);
        }
        bool flag = false;
        Graphics gr;
        int k = 0;
        int r = 55, g = 0, b = 55;
        int x1, x2, y1, y2;
        public Graphics gr1;
        Bitmap bmp;
        Pen pen;
        Graphics g1;
        
        private void Zadanie2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            { flag = true; k++; if (k > 1) { flag = false; k = 0; } }
        }

        private void Zadanie2_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 6 && textBox1.Text.Length <= 6)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Zadanie2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBox1.Text, out r);
            Int32.TryParse(textBox2.Text, out g);
            Int32.TryParse(textBox3.Text, out b);
            if (r > 255) { textBox1.Text = "255"; }
            if (g > 255) { textBox2.Text = "255"; }
            if (b > 255) { textBox3.Text = "255"; }
            
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pen = new Pen(Color.FromArgb(r, g, b));
            g1 = Graphics.FromImage(pic1);
            if (e.Button == MouseButtons.Left)
            {
                if (flag)
                {
                    g1.Clear(Color.White);
                    label1.Text = "x: " + e.X.ToString();
                    label2.Text = "y: " + e.Y.ToString();
                    g1.DrawLine(pen, x1, y1, e.X, e.Y);
                    pictureBox1.Image = pic1;
                }
                else
                {
                    g1.Clear(Color.White);
                    if (x1 > e.X) x1 = e.X;
                    if (y1 > e.Y) y1 = e.Y;
                    label1.Text = "x: " + e.X.ToString();
                    label2.Text = "y: " + e.Y.ToString();
                    g1.DrawRectangle(pen, x1, y1, Math.Abs(e.X - x1), Math.Abs(e.Y - y1));
                    pictureBox1.Image = pic1;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                g1.Clear(Color.White);
                if (x1 > e.X) x1 = e.X;
                if (y1 > e.Y) y1 = e.Y;
                label1.Text = "x: " + e.X.ToString();
                label2.Text = "y: " + e.Y.ToString();
                g1.DrawEllipse(pen, x1, y1, Math.Abs(e.X - x1), Math.Abs(e.Y - y1));
                pictureBox1.Image = pic1;
            }
           
        }
    }
}
