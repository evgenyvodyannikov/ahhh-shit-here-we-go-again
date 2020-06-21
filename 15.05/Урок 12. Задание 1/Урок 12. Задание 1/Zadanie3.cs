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
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int imax = 100;
            int t = 2;
            int amp = 80;
            int h = 100;
            int x0 = 20;
            int y0 = h + amp;
            double[] f = new double[imax * t + 10];
            if (comboBox1.Text == "Sin(x)")
            {
                for (int i = 0; i < imax * t; i++)
                {
                    f[i] = Math.Round(amp * Math.Sin(2 * Math.PI / imax * i));
                }
                Graphics g = Graphics.FromHwnd(this.Handle);
                g.Clear(Color.WhiteSmoke);
                Pen pen = Pens.Black;

                g.DrawString("График синусоиды", new Font("Arial", 14), Brushes.Red, 30, 60);
                g.DrawLine(pen, x0, y0, x0 + imax * t, y0);
                g.DrawLine(pen, x0, y0 - amp, x0, y0 + amp);
                g.DrawString("Y", new Font("Arial", 10), Brushes.Black, 10, 20);
                g.DrawString("X", new Font("Arial", 10), Brushes.Black, x0 + imax * t, y0);
                for (int i = 0; i < imax * t; i++)
                {
                    int f1 = y0 - (int)f[i];
                    int f2 = y0 - (int)f[i + 1];
                    g.DrawLine(pen, x0 + i, f1, x0 + i + 1, f2);
                }
            }
            else if (comboBox1.Text == "Cos(x)")
            {
                for (int i = 0; i < imax * t; i++)
                {
                    f[i] = Math.Round(amp * Math.Cos(2 * Math.PI / imax * i));
                }
                Graphics g = Graphics.FromHwnd(this.Handle);
                g.Clear(Color.WhiteSmoke);
                Pen pen = Pens.Black;

                g.DrawString("График косинусоиды", new Font("Arial", 14), Brushes.Red, 30, 60);
                g.DrawLine(pen, x0, y0, x0 + imax * t, y0);
                g.DrawLine(pen, x0, y0 - amp, x0, y0 + amp);
                g.DrawString("Y", new Font("Arial", 10), Brushes.Black, 10, 20);
                g.DrawString("X", new Font("Arial", 10), Brushes.Black, x0 + imax * t, y0);
                for (int i = 0; i < imax * t - 5; i++)
                {
                    int f1 = y0 - (int)f[i];
                    int f2 = y0 - (int)f[i + 1];
                    g.DrawLine(pen, x0 + i, f1, x0 + i + 1, f2);
                }
            }
            else if (comboBox1.Text == "Парабола")
            {
                for (int i = 0; i < imax ; i++)
                {
                    f[i] = Math.Round(amp * Math.Cos(2 * Math.PI / imax * i));
                }
                Graphics g = Graphics.FromHwnd(this.Handle);
                g.Clear(Color.WhiteSmoke);
                Pen pen = Pens.Black;

                g.DrawString("График параболы", new Font("Arial", 14), Brushes.Red, 30, 60);
                g.DrawLine(pen, x0, y0, x0 + imax * t, y0);
                g.DrawLine(pen, x0, y0 - amp, x0, y0 + amp);
                g.DrawString("Y", new Font("Arial", 10), Brushes.Black, 10, 20);
                g.DrawString("X", new Font("Arial", 10), Brushes.Black, x0 + imax * t, y0);
                for (int i = 10; i < imax - 10; i++)
                {
                    x0 = 50;
                    int f1 = y0 - (int)f[i];
                    int f2 = y0 - (int)f[i + 1];
                    g.DrawLine(pen, x0 + i, f1, x0 + i + 1, f2);
                }

            }
        }

        private void Zadanie3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
    
}
