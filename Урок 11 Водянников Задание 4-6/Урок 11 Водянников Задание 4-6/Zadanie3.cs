using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Урок_11_Водянников_Задание_4_6
{
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
        }
        int deltaX = 0;
        int deltaY = 0;
        bool isclicked = false;
        Rectangle rect = new Rectangle(200, 200, 400, 100);
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            HatchBrush hBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Red, Color.FromArgb(255, 128, 255, 255));
            Pen pen = new Pen(Color.Black, 2);
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.X < rect.X + rect.Width) && (e.X > rect.X))
                if((e.Y < rect.Y + rect.Height) && (e.Y > rect.Y))
                {
                    isclicked = true;
                    deltaX = e.X - rect.X;
                    deltaY = e.Y - rect.Y;
                }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isclicked)
            {
                rect.X = e.X - deltaX;
                rect.Y = e.Y - deltaY;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isclicked = false;
        }
    }
}
