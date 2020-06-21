using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_10_30._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Zadanie1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new Zadanie2();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f2 = new Zadanie3();
            f2.ShowDialog();
        }
    }
}
