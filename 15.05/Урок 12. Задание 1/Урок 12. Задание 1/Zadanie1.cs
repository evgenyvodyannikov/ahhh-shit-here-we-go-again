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
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }
        Graphics gr;
        private void button1_Click(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
            Pen MyPen = new Pen(Color.Red);
            gr.DrawEllipse(MyPen, 55, 55, 100, 50);
            MyPen = new Pen(Color.Navy);
            gr.DrawLine(MyPen, 30, 55, 300, 55);
            gr.FillRectangle(Brushes.Blue, 90, 100, 300, 100);
            gr.DrawString("Paint!", new Font("Arial", 22), new SolidBrush(Color.Green), 10, 10);
            button1.Enabled = false;
        }
    }
}
