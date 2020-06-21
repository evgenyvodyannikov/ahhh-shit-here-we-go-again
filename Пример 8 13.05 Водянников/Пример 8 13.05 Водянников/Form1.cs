using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пример_8_13._05_Водянников
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Graphics gr;
        int x1 = 0;
        int x2 = 0;
        int y1 = 0;
        int y2 = 0;
        int radius = 55;
        int r, g, b = 0;
        int elips = 55;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(bmp);
        }

        public void getParams()
        {
            try
            {
                Int32.TryParse(textBox1.Text, out x1);
                Int32.TryParse(textBox2.Text, out y1);
                Int32.TryParse(textBox4.Text, out x2);
                Int32.TryParse(textBox3.Text, out y2);
                Int32.TryParse(textBox8.Text, out radius);
                Int32.TryParse(textBox5.Text, out r);
                Int32.TryParse(textBox6.Text, out g);
                Int32.TryParse(textBox7.Text, out b);
                Int32.TryParse(textBox9.Text, out elips);
            }
            catch { }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBox5.Text, out r);
            Int32.TryParse(textBox6.Text, out g);
            Int32.TryParse(textBox7.Text, out b);
            if (r > 255){ textBox5.Text = "255"; }
            if (g > 255) { textBox6.Text = "255"; }
            if (b > 255) { textBox7.Text = "255"; }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBox9.Text, out elips);
            if (elips > 360) { textBox9.Text = "360"; }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (tb.Text.Length == 6 && tb.Text.Length <= 6)
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

        public void Obnovit()
        {
            pictureBox1.Image = bmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getParams();
            Pen pen = new Pen(Color.FromArgb(r, g, b), 2);
            Button bt = (Button)sender;
            if (bt == button1)
            {
                  
                gr.DrawEllipse(pen, x1, y1, 2, 2);
                Obnovit();
            }
            if (bt == button2)
            {
                if ((y1 <= 0) || (x1 <= 0)) MessageBox.Show("Координаты должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if ((x2 <= 0) || (y2 <= 0)) MessageBox.Show("Координаты второй точки должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                {
                    gr.DrawLine(pen, x1, y1, x2, y2);
                    Obnovit();
                }
            }
            if (bt == button3)
            {
                int minx = x1;
                int miny = y1;
                if ((y1 <= 0) || (x1 <= 0)) MessageBox.Show("Координаты должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if ((x2 <= 0) || (y2 <= 0)) MessageBox.Show("Координаты второй точки должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if(minx > x1) minx = x1;
                    if(minx > x2) minx = x2;
                    if (miny > y1) miny = y1;
                    if (miny > y2) miny = y2;
                    gr.DrawRectangle(pen, minx, miny, Math.Abs(x2-x1) + 1, Math.Abs(y2-y1) + 1);
                    x2 -= x1;
                    y2 -= y1;
                    Obnovit();
                }

            }
            if (bt == button4)
            {
                try {
                    if ((y1 <= 0) || (x1 <= 0)) MessageBox.Show("Координаты должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if ((x2 <= 0) || (y2 <= 0)) MessageBox.Show("Координаты второй точки должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (radius <= 0) MessageBox.Show("Радиус должен быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (elips <= 0) MessageBox.Show("Сегмент элипса должен быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    gr.DrawArc(pen, x1, y1, x2, y2, elips, elips);
                } catch { }
                Obnovit();
            }
            if (bt == button5)
            {
                if ((y1 <= 0) || (x1 <= 0)) MessageBox.Show("Координаты должны быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (radius <= 0) { MessageBox.Show("Радиус должен быть больше нуля!!", "Исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                gr.DrawEllipse(pen, x1, y1, radius * 2, radius * 2);
                Obnovit();
            }
            if (bt == button6)
            {
                Pen pen1 = new Pen(Color.Gray, 1);
                for (int i = 0; i <= bmp.Width; i += 15)
                {
                    if (i % 50 == 0)
                    {
                        gr.DrawLine(new Pen(Color.DarkMagenta), i, 0, i, Convert.ToInt32(pictureBox1.Height));
                        gr.DrawString(i.ToString(), new Font("Cambria", 12), Brushes.DarkMagenta, 0, i);
                    }
                    else
                    {
                        gr.DrawLine(pen1, i, 0, i, Convert.ToInt32(pictureBox1.Height));
                    }
                    if (i % 50 == 0)
                    {
                        gr.DrawLine(new Pen(Color.DarkMagenta), 0, i, Convert.ToInt32(pictureBox1.Width), i);
                        gr.DrawString(i.ToString(), new Font("Cambria", 12), Brushes.DarkMagenta, i, 0);
                    }
                    else
                    {
                        gr.DrawLine(pen1, 0, i, Convert.ToInt32(pictureBox1.Width), i);
                    }
                    Obnovit();
                }
            }
            if (bt == button7)
            {
                gr.Clear(Color.White);
                Obnovit();
            }
        }
    }
}
