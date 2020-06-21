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

namespace _12._05_Vodyannikov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen P;
        public void Liniya(int Random, int rand)
        {
            switch (Random)
            {
                case 1:
                    P = new Pen(Color.Magenta, rand);
                    P.DashStyle = DashStyle.Dot; // линия будет из точек
                    P.StartCap = LineCap.Square; // квадрат будет началом линии
                    P.EndCap = LineCap.ArrowAnchor; // стрелка будет завершением линии
                    break;
                case 2:
                    P = new Pen(Color.LimeGreen, rand);
                    P.DashStyle = DashStyle.Dash; // линия будет состоять из штрихов
                    P.StartCap = LineCap.Round; // началом линии будет круг
                    P.EndCap = LineCap.Round; // завершением линии будет круг
                    break;
                case 3:
                    P = new Pen(Color.BlueViolet, rand);
                    P.DashStyle = DashStyle.DashDotDot; // линия будет состоять из шаблона "штрих - две точки"
                    P.StartCap = LineCap.Flat; // плоское начало линии
                    break;
                case 4:
                    P = new Pen(Color.Chocolate, rand);
                    P.DashStyle = DashStyle.Solid; // линия будет сплошной
                    P.StartCap = LineCap.Triangle; // началом линии будет треугольник
                    P.EndCap = LineCap.Triangle; // завершением линии будет треугольник
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            g.Clear(Color.White);
            int x = r.Next(10, 700);
            int y = r.Next(10, 300);
            int x2 = r.Next(50, 800);
            int y2 = r.Next(50, 400);
            Liniya(r.Next(1, 5), r.Next(1, 10)); // вызываем метод, в котором рандомно будет выбран стиль линии
            g.DrawLine(P, x, y, x2, y2); // рисуем линию
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Width = 0; // у меня не получилось вызвать событие Paint нажатием кнопки, так что я просто меняю размер формы до 0,0 и возвращаю к исходному и линия перерисовывется
            this.Height = 0;
            this.Width = 816; 
            this.Height = 489;
        }
    }
}
