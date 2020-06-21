using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodyannikov_07._05_Zadanie_1_3
{
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }


        int flag = 0;
        private void Zadanie1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            { flag = 1; }
            else
            { label2.Text = e.KeyData.ToString(); flag = 0; label2.ForeColor = Color.Blue; }
        }
        private void Zadanie1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (flag == 1)
            { label2.Text = e.KeyChar.ToString(); label2.ForeColor = Color.Green; flag = 0; }
        }

        private void Zadanie1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
