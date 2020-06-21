using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace massivy2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n > 999) MessageBox.Show("Для оптимальной работы программы рекомендуется ввести значение n < 1000", "Исключение");
                else
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("Номер элемента", "Номер элемента");
                    dataGridView1.Columns.Add("Элемент массива", "Элемент массива");
                    dataGridView1.Rows.Add(n);
                    int[] mas = new int[n];
                    Random r = new Random();
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = r.Next(-2000, 2000);
                        dataGridView1.Rows[i].Cells[0].Value = i;
                        dataGridView1.Rows[i].Cells[1].Value = mas[i];
                    }
                    dataGridView2.Columns.Clear();
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Add("Номер элемента", "Номер элемента");
                    dataGridView2.Columns.Add("Элемент массива", "Элемент массива");
                    dataGridView2.Rows.Add(n / 2);
                    int k = 0;
                    int l = 0;
                    for (int i = 0; i < mas.Length / 2; i++)
                    {
                        mas[i] = mas[l];
                        l += 2;
                    }
                    for (int i = 0; i < n / 2; i++)
                    {
                        dataGridView2.Rows[i].Cells[0].Value = k;
                        dataGridView2.Rows[i].Cells[1].Value = mas[i];
                        k++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Значение n введено неверно. Повторите ввод", "Исключение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Закрыть программу", "Подтвердите", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
            else { }
        }
    }
}
