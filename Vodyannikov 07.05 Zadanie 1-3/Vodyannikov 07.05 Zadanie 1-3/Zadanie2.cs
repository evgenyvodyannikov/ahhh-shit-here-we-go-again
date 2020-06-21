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
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void Nadno()
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }
        private void Zadanie2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (flag == 1)
            { listBox1.Items.Add(DateTime.Now + " Нажата клавиша " + e.KeyChar.ToString()); flag = 0; Nadno(); }
        }

        private void Zadanie2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            { flag = 1; }
            else
            { listBox1.Items.Add(DateTime.Now + " Нажата клавиша " + e.KeyData.ToString()); flag = 0; Nadno(); }
        }

        private void Zadanie2_Load(object sender, EventArgs e)
        {
        }
        private void Zadanie2_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add(DateTime.Now + " Нажата кнопка мыши " + e.Button.ToString());
            Nadno();
        }
        private void button1_Click_1(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
