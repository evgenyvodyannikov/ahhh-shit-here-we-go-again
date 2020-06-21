using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer3
{
    public partial class Form1 : Form
    {
        Exception pp = new Exception();
        private Graphics g;
        private System.Drawing.Bitmap psource;
        private Rectangle rct;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                psource = new Bitmap("Properties\\EWyZ-1.bmp");

            }
            catch
            {
                MessageBox.Show(pp.ToString(), "Бегущая строка");
                this.Close();
                return;

            }
            g = this.CreateGraphics();
            rct.X = 0;
            rct.Y = Convert.ToInt16(this.ClientSize.Height - psource.Height);
            rct.Width = psource.Width;
            rct.Height = psource.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1;
            if (Math.Abs(rct.X) > rct.Width)
                rct.X += rct.Width;
            for (int i=0; i<=Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(psource, rct.X + i * rct.Width, rct.Y);

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                if (timer1.Enabled != false)
                    timer1.Enabled = false;
            }
            else
            {
                if (timer1.Enabled != true)
                    timer1.Enabled = true;
            }
        }
    }
}
