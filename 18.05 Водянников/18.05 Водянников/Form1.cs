using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _18._05_Водянников
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }
        
        Bitmap bmp;
        Graphics g;
        int x1 = 0, x2 = 0, y1 = 0, y2 = 0, otkl1 = 0, otkl2 = 0, otkl3 = 0, otkl4 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random r = new Random();
        Point[] pt, pt2;
        public void SozdanieTochek()
        {
            x1 = r.Next(10, 200);
            x2 = r.Next(10, 200);
            y1 = r.Next(10, 200);
            y2 = r.Next(10, 200);
            otkl1 = r.Next(10, 200);
            otkl2 = r.Next(10, 200);
            otkl3 = r.Next(10, 200);
            otkl4 = r.Next(10, 200);
            pt = new Point[4];
            pt[0] = new Point(r.Next(10, 180), r.Next(10, 180));
            pt[1] = new Point(r.Next(10, 180), r.Next(10, 180));
            pt[2] = new Point(r.Next(10, 180), r.Next(10, 180));
            pt[3] = new Point(r.Next(10, 180), r.Next(10, 180));
            pt2 = new Point[4];
            pt2[0] = new Point(r.Next(50, 280), r.Next(90, 280));
            pt2[1] = new Point(r.Next(50, 280), r.Next(90, 280));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.DarkMagenta, 1);
            Button b = (Button)sender;
           
            if (b == button1)
            {
                SozdanieTochek();
                g.DrawRectangle(p, x1, x2, y1, y2);
                g.DrawEllipse(p, x1, x2, y1, y2);
                g.DrawRectangle(p, x1 + otkl1, x2 + otkl2, y1 + otkl3, y2 + otkl4);
                g.DrawEllipse(p, x1 + otkl4, x2 + otkl3, y1 + otkl2, y2 + otkl1);
                g.DrawClosedCurve(p, pt);
                g.DrawPolygon(p, pt2);
            }
            if (b == button2)
            {
                g.FillRectangle(Brushes.DarkGray, x1, x2, y1, y2);
                g.FillEllipse(Brushes.Blue, x1, x2, y1, y2);
                g.FillRectangle(Brushes.LimeGreen, x1 + otkl1, x2 + otkl2, y1 + otkl3, y2 + otkl4);
                g.FillEllipse(Brushes.Violet, x1 + otkl4, x2 + otkl3, y1 + otkl2, y2 + otkl1);
                g.FillClosedCurve(Brushes.OrangeRed, pt);
                g.FillPolygon(Brushes.DarkSeaGreen, pt2);
            }
            pictureBox1.Image = bmp;
        }
    }
}
