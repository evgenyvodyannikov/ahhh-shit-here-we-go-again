using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samostoyat_Massivy_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Введите значение N!!");
                int n = Convert.ToInt32(textBox1.Text);
                if (textBox2.Text == "")
                    MessageBox.Show("Введите длину массива!!");
                int k = Convert.ToInt32(textBox2.Text); 
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("Элемент массива", "Элемент массива");
                dataGridView1.Rows.Add(k);
                
                Random r = new Random();
                int[] m = new int[k];
                for (int i = 0; i < k; i++)
                {
                    m[i] = r.Next(n);
                    dataGridView1.Rows[i].Cells[0].Value = m[i];
                }
            }
            catch
            {

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 3 && textBox1.Text.Length <= 3)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '0')
            {
                if ((textBox1.Text.Length == 0)) 
                { 
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
            {
                if (textBox2.Text.Length == 3 && textBox2.Text.Length <= 3)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '0')
            {
                if ((textBox2.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
    }
}
