using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_8_IS_201_Vodyannikov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool proverka(int i)
        {
            int vspomog = i;
            if (vspomog != 0)
            {
                int sumchisel = 0;
                while (vspomog > 0)
                {
                    sumchisel += vspomog % 10;
                    vspomog /= 10;
                }
                return i % sumchisel == 0;
            }
            else
                return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Элемент массива", "Элемент массива");
            int n = textBox1.Lines.Length;
            int[] m = new int[n];
            int k = 0;
            string s = null;
            for (int i = 0; i < n; i++)
            {
                //Type t = textBox1.Lines[i].GetType(); //t.Equals(typeof(Int32)
                try
                {
                    if (Convert.ToInt32(textBox1.Lines[i]) >= 0)
                    {
                        m[k] = Convert.ToInt32(textBox1.Lines[i]); k++;
                    }
                }
                catch
                {
                    s += i;
                    s += ',';
                    s += ' ';
                }
            }
            MessageBox.Show("Строки под номерами: " + Convert.ToString(s) +"не были записаны в массив!!");
                        dataGridView1.Rows.Add(n);

            for (int i = 0; i < k; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = m[i];
            }
            label9.Text = Convert.ToString(k);



            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += m[i];
            }
            label10.Text = Convert.ToString(sum);


            int p = 1;
            for (int i = 0; i < k; i++)
            {
                p *= m[i];
            }
            label11.Text = Convert.ToString(p);
            label12.Text = Convert.ToString(sum/n);


            int max = 0;
            for (int i = 0; i < k; i++)
            {
                if (m[i]>max)
                {
                    max = m[i];
                }
            }


            label13.Text = Convert.ToString(max);
            int min = 999;
            for (int i = 0; i < k; i++)
            {
                if (m[i] < min)
                {
                    min = m[i];
                }
            }
            label14.Text = Convert.ToString(min);
            int kolvo = 0;
            for (int i = 0; i < k; i++)
            {
                if (proverka(m[i]))
                    kolvo++;
            }
            label15.Text = Convert.ToString(kolvo);

        }
    }
}
