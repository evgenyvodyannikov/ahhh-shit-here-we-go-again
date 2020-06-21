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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if(bt == button1)
            {
                Form f = new Zadanie1();
                f.ShowDialog();
            }
            if (bt == button2)
            {
                Form f = new Zadanie2();
                f.ShowDialog();
            }
            if (bt == button3)
            {
                Form f = new Zadanie3();
                f.ShowDialog();
            }
            if (bt == button4)
            {
                Form f = new Zadanie4();
                f.ShowDialog();
            }
        }
    }
}
