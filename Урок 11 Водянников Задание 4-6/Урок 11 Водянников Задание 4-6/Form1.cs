using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_11_Водянников_Задание_4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == button1)
            {
                Form f = new Zadanie1();
                f.ShowDialog();
            }
            if (b == button2)
            {
                Form f = new Zadanie2();
                f.ShowDialog();
            }
            if (b == button3)
            {
                Form f = new Zadanie3();
                f.ShowDialog();
            }
        }
    }
}
