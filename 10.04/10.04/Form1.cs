using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Элемент массива", "Элемент массива");
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Add("Элемент массива", "Элемент массива");
            Random rand = new Random();
            int kolvo = 12;
            int min = -50;
            int max = 50;
            int sum = 0;
            try
            {
                if (textBox1.Text == "")
                MessageBox.Show("Не задано кол-во элементов массива! Выставлено значение по умолчанию");
                kolvo = Convert.ToInt32(textBox1.Text);
                
                int[] Mas = new int[kolvo];
                int[] Mas1 = new int[kolvo];
                int k = 0;
                min = Convert.ToInt32(textBox2.Text);
                max = Convert.ToInt32(textBox3.Text);
                dataGridView1.Rows.Add(kolvo);
                for (int i = 0; i < kolvo; i++)
                {
                    Mas[i] = rand.Next(min, max); dataGridView1.Rows[i].Cells[0].Value = Mas[i];
                    if (Mas[i] % 2 == 0)
                    {
                        sum += Mas[i];
                        Mas1[k] = Mas[i];
                        k++;
                    }
                }
                label11.Text = Convert.ToString(sum);
                dataGridView2.Rows.Add(k);
                int l = 0;
                for (int i = 0; i < k; i++)
                {
                        dataGridView2.Rows[l].Cells[0].Value = Mas1[i];
                        l++;
                }
            }
            catch
            {

                try
                {
                    if ((textBox2.Text == "") || (textBox3.Text == ""))
                    MessageBox.Show("Не верно заданы значения min, max! Выставлены значения по умолчанию");
                    min = Convert.ToInt32(textBox2.Text);
                    max = Convert.ToInt32(textBox3.Text);
                    if (min > max)
                        MessageBox.Show("Минимум не может быть больше максимума! Выставлены значения по умолчанию");
                    dataGridView1.Rows.Clear();
                    int[] Mas = new int[kolvo];
                    int[] Mas1 = new int[kolvo];
                    int k = 0;
                    dataGridView1.Rows.Add(kolvo);
                    for (int i = 0; i < kolvo; i++)
                    {
                        Mas[i] = rand.Next(min, max); dataGridView1.Rows[i].Cells[0].Value = Mas[i];
                        if (Mas[i] % 2 == 0)
                        {
                            sum += Mas[i];
                            Mas1[k] = Mas[i];
                            k++;
                        }
                    }
                    label11.Text = Convert.ToString(sum);
                    dataGridView2.Rows.Add(k);
                    int l = 0;
                    for (int i = 0; i < k; i++)
                    {
                        dataGridView2.Rows[l].Cells[0].Value = Mas1[i];
                        l++;
                    }
                }
                catch
                {
                    textBox2.Text = "";
                    textBox3.Text = "";

                    dataGridView1.Rows.Clear();
                    int[] Mas = new int[kolvo];
                    int[] Mas1 = new int[kolvo];
                    int k = 0;
                    dataGridView1.Rows.Add(kolvo);
                    for (int i = 0; i < kolvo; i++)
                    {
                        Mas[i] = rand.Next(-50, 50); dataGridView1.Rows[i].Cells[0].Value = Mas[i];
                        if (Mas[i] % 2 == 0)
                        {
                            sum += Mas[i];
                            Mas1[k] = Mas[i];
                            k++;
                        }
                    }
                    label11.Text = Convert.ToString(sum);
                    dataGridView2.Rows.Add(k);
                    int l = 0;
                    for (int i = 0; i < k; i++)
                    {
                        dataGridView2.Rows[l].Cells[0].Value = Mas1[i];
                        l++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 2 && textBox1.Text.Length <= 2)
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
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox2.Text.Length == 2 && textBox2.Text.Length <= 2)
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
            e.Handled = true; // true - остальные символы запрещены
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox3.Text.Length == 2 && textBox3.Text.Length <= 2)
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
            e.Handled = true; // true - остальные символы запрещены
        }
    }
}
