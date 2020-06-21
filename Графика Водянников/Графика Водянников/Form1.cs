using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Графика_Водянников
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int x = 100, y = 100;
        int dx, dy;
        int xx = 0;
        int yy = 0;
        private void Form1_Resize(object sender, EventArgs e)
        {
            dx = (this.ClientSize.Width) / x;
            dy = (this.ClientSize.Height) / y;
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(xx, yy);
            Point start = new Point(dx*12, 36 * dy);
            Point control1 = new Point(dx*18, dy*45);
            Point control2 = new Point(dx*30, dy*45);
            Point end1 = new Point(dx*38, dy*36);
            Point control11 = new Point(dx * 38, dy * 36);
            Point control12 = new Point(dx * 38, dy * 36);
            Point end2 = new Point(dx*33, dy*80);
            Point control111 = new Point(dx * 33, dy * 80);
            Point control112 = new Point(dx * 33, dy * 80);
            Point end3 = new Point(dx * 17, dy * 80);
            Point control1111 = new Point(dx * 17, dy * 80);
            Point control1122 = new Point(dx * 17, dy * 80);
            Point[] stakan = { start, control1, control2, end1, control11, control12, end2, control111, control112, end3, control1111, control1122, start};
            g.FillClosedCurve(Brushes.Red, stakan);

            g.FillEllipse(Brushes.Black, dx * 15, dy * 22, 12 * dx, 12 * dx);
            g.FillEllipse(Brushes.Lime, 25 * dx, 17 * dy, 10 * dx, 10 * dx);
            g.FillEllipse(Brushes.LightGray, 25 * dx, 30 * dy, 8 * dx, 8 * dx);

            g.FillRectangle(Brushes.Blue, dx * 33 /1.4f, dy * 80, 3*dx, 20*dy);

            

            PointF s = new PointF(dx * 23.5f, 98 * dy);
            PointF s1 = new PointF(dx * 18, 103 * dy);
            PointF s2 = new PointF(dx * 32.2f, 103 * dy);
            PointF s3 = new PointF(dx * 26.5f, 98 * dy);
            
            PointF[] pol = { s, s1, s2, s3};
            g.FillPolygon(Brushes.Blue, pol);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
   
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == button1)
            {
                xx += 50;
                pictureBox1.Invalidate();
            }
            if (b == button2)
            {
                xx -= 50;
                pictureBox1.Invalidate();
            }
            if (b == button4)
            {
                yy += 50;
                pictureBox1.Invalidate();
            }
            if (b == button3)
            {
                yy -= 50;
                pictureBox1.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dx = (this.ClientSize.Width) / x;
            dy = (this.ClientSize.Height) / y;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
