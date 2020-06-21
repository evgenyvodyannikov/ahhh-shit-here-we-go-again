using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_12.Задание_1
{
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
        }
        Bitmap mbit;
        Graphics gr;
        private void button1_Click(object sender, EventArgs e)
        {
            mbit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(mbit);
            gr.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            Pen MyPen = new Pen(Color.Red);



            gr.DrawEllipse(MyPen, 55, 55, 100, 50);
            MyPen = new Pen(Color.Navy);
            gr.DrawLine(MyPen, 30, 55, 300, 55);
            gr.FillRectangle(Brushes.Blue, 90, 100, 300, 100);
            gr.DrawString("Paint!", new Font("Arial", 22), new SolidBrush(Color.Green), 10, 10);
            pictureBox1.Image = mbit;
            button1.Enabled = false;
        }
    }
}
