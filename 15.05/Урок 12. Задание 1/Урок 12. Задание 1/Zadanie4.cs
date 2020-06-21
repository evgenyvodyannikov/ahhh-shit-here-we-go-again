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
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0;
            for (int x = -10; x <= 10; x++)
            {
                y = Math.Sin(Math.PI / 5 * x);
                chart1.Series["Cos(x)"].Points.AddXY(x, y);
            }
            for (int x = -10; x <= 10; x++)
            {
                y = Math.Cos(Math.PI / 5 * x);
                chart1.Series["Sin(x)"].Points.AddXY(x, y);
            }
            for (double x = -10; x <= 10; x++)
            {
                y = 0.02*x * x;
                chart1.Series["Парабола"].Points.AddXY(x, y);
            }
            button1.Enabled = false;
        }
    }
}
