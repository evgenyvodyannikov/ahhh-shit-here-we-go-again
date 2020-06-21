using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Urok_13_Водянников
{
    public partial class Form1 : Form
    {
        public int speed = 1;
        const int N_max = 50;
        public int N = 10;
        Random r = new Random();
        public Sharik [] shar = new Sharik[N_max];
        public Graphics g;
        SolidBrush brf;
        public bool IsClicked = false;
        public int deltaX = 0;
        public int deltaY = 0;
        public int rectX = 200;
        public int rectY = 200;
        public int X; public int Y;
        Bitmap bmp;
        bool isclicked = false;
        public Rectangle rect = new Rectangle(200, 200, 400, 100);
        HatchBrush hBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Red, Color.FromArgb(255, 128, 255, 255));
        Pen pen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            this.Width = 1350;
            this.Height = 700;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Выберите кол-во шаров!", "Исключение.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBox2.SelectedItem == null) { MessageBox.Show("Выберите скорость!", "Исключение.", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                N = Int32.Parse(comboBox1.Text);
                speed = Int32.Parse(comboBox2.Text);
                g.Clear(BackColor);
                N = Int32.Parse(comboBox1.Text);
                int rch;
                for (int i = 0; i < N; i++)
                {
                    rch = r.Next(100000);
                    shar[i] = new Sharik(rch, speed);
                }
                timer1.Enabled = true;
                IsClicked = true;
                brf = new SolidBrush(BackColor);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < rectX + rect.Width) && (e.X > rectX))
                if ((e.Y < rectY + rect.Height) && (e.Y > rectY))
                {
                    isclicked = true;
                    deltaX = e.X - rectX;
                    deltaY = e.Y - rectY;
                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isclicked = false;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isclicked)
            {
                rectX = e.X - deltaX;
                rectY = e.Y - deltaY;
                X = rectX;
                Y = rectY;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(hBrush, rectX, rectY, 400, 100);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (IsClicked)
            {
                Sharik s;
                for (int i = 0; i < N; i++)
                {
                    s = shar[i];
                    g.FillEllipse(brf, s.x + 2, s.y + 2, 2 * s.radius, 2 * s.radius);
                    pictureBox1.Invalidate();
                    s.Next(X, Y);
                    g.FillEllipse(s.br, s.x + 2, s.y + 2, 2 * s.radius, 2 * s.radius);
                    pictureBox1.Invalidate();
                }

            }
        }
    }
    public class Sharik : Form1
    {
        public int radius;
        public int x;
        public int y;
        public SolidBrush br;
        int dx;
        int dy;
        public Sharik(int rch, int speed)
        {
            Random r = new Random(rch);
            radius = r.Next(30, 50);
            br = new SolidBrush(RandomColor(rch));
            x = r.Next(1, ClientRectangle.Width - 2 * radius);
            y = r.Next(1, ClientRectangle.Height - 2 * radius);
            dx = speed;
            dy = speed;
        }
        public void Next(int X, int Y)
        {
            if (x >= X - 2 * radius && y >= Y - 2 * radius)
                if (x <= X + rect.Width && y <= Y + rect.Height)
                { dy = -dy; if (x + radius * 2 > X) { if (X + rect.Width / 2 >= x) x = X - 2 * radius; else x = X + rect.Width + 2 * radius; } }
            if (x >= X - 2 * radius && y >= Y - 2 * radius)
                if (x <= X + rect.Width && y <= Y + rect.Height)
                { dx = -dx; if (y + radius * 2 > Y) { if (Y + rect.Height / 2 >= x) y = Y - 2 * radius; else x = Y + rect.Height + 2 * radius; } }
            if (x >= this.Width - 2 * radius)
                dx = -dx;
            if (x < 0)
                dx = -dx;
            x += dx;
            if (y >= this.Height - 2 * radius)
                dy = -dy;
            if (y < 0)
                dy = -dy;
            y += dy;
        }
        public Color RandomColor(int rch)
        {
            int r, g, b;
            byte[] bytes1 = new byte[3];
            Random rnd1 = new Random(rch);
            rnd1.NextBytes(bytes1);
            r = (Int16)bytes1[0];
            g = (Int16)bytes1[1];
            b = (Int16)bytes1[2];
            return Color.FromArgb(r, g, b);
        }
    }
}
