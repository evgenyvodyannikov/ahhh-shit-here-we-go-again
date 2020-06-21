using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_7_Vodyannikov
{
    public partial class Form1 : Form
    {
        string[] Valuta = { "Фунт стерлингов", "Канадский доллар", "Доллар США", "Норвежских крон", "Датских крон" };
        string[] Valuta1 = { " Ф.Ст", " К.Дол", " Д.США", " Норв.Крон", " Дат.Крон"};
        double[] Kurs = { 92.45, 52.65, 74.08, 7.12, 10.79 };
        double[] Vznos = new double[5];
        int[] Stavka = { 5, 4, 6, 2, 3 };
        double[] Komis = new double[5];
        double[] SumR = new double[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(textBox1.Text) > 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = Valuta[i];
                        dataGridView1.Rows[i].Cells[1].Value = Kurs[i];
                        dataGridView1.Rows[i].Cells[2].Value = textBox1.Text;
                        Vznos[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        dataGridView1.Rows[i].Cells[3].Value = Stavka[i];
                        Komis[i] = Vznos[i] * Stavka[i] / 100;
                        dataGridView1.Rows[i].Cells[4].Value = Komis[i];
                        SumR[i] = (Vznos[i] - Komis[i]) / Kurs[i];
                        dataGridView1.Rows[i].Cells[5].Value = String.Format("{0:f2}", SumR[i]);
                    }
                }
                else
                {MessageBox.Show("Количество валюты для конвертации должно быть больше 0!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            catch
            { MessageBox.Show("Количество валюты для конвертации должно быть больше 0!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "";
                dataGridView1.Rows[i].Cells[1].Value = "";
                dataGridView1.Rows[i].Cells[2].Value = "";
                dataGridView1.Rows[i].Cells[3].Value = "";
                dataGridView1.Rows[i].Cells[4].Value = "";
                dataGridView1.Rows[i].Cells[5].Value = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mx = 500; int a = 300;
            int x0 = 40; int y0 = 500;
            int[] h = new int[5];
            int wc = 40; int dc = 25;
            int m = 0;
            for (int i = 1; i < 5; i++)
            {
                if (SumR[i] > SumR[m]) m = i;
            }
            for (int i = 0; i < 5; i++)
            {
                h[i] = (int)Math.Round((y0 - a) * SumR[i] / SumR[m]);
            }
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen pen = Pens.Blue;
            g.DrawString("Диаграмма коверсии валют разных стран", new Font("Arial", 14), Brushes.Blue, 100, a - 50);
            g.DrawLine(pen, x0, y0, x0, y0 - h[m]);
            g.DrawLine(pen, x0, y0, x0 + mx, y0);
            x0 = x0 + dc;
            Brush brush = Brushes.Blue; 
            for (int i = 0; i < 5; i++)
            {
                g.FillRectangle(brush, x0, y0 - h[i], wc, h[i]);
                g.DrawRectangle(pen, new Rectangle(x0, y0 - h[i], wc, h[i]));
                g.DrawString(String.Format("{0:f2}", SumR[i]) + Valuta1[i], new Font("Arial", 10), Brushes.Black, x0 - 20, y0 - h[i] - 20);
                x0 = x0 + wc + dc;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x0 = 40; int y0 = 280;
            Graphics g = Graphics.FromHwnd(this.Handle);
            Brush brush = Brushes.White;
            g.FillRectangle(brush, x0, y0, 510, y0 + 200);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += (double)dataGridView1.Rows[i].Cells[4].Value;
            }
            label2.Text = Convert.ToString("Ответ: " + sum / 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != " " && textBox2.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[1].Value != null)
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBox2.Text))
                            {
                                dataGridView1.Rows[i].Cells[1].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска!", "Ошибка!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 5 && textBox1.Text.Length <= 5)
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
