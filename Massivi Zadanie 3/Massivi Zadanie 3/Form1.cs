using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massivi_Zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = int.Parse(textBox1.Text);
                int[,] a = new int[2 * n, 2 * n];
                for (int i = 0; i < n; ++i)
                {
                    for (int k = 0; k < n; ++k)
                    {
                        a[i, k] = 1;
                    }
                }
                for (int i = n; i < 2 * n; ++i)
                {
                    for (int k = 0; k < n; ++k)
                    {
                        a[i, k] = 3;
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    for (int k = n; k < 2 * n; ++k)
                    {
                        a[i, k] = 2;
                    }
                }
                for (int i = n; i < 2 * n; ++i)
                {
                    for (int k = n; k < 2 * n; ++k)
                    {
                        a[i, k] = 4;
                    }
                }
                string s = Convert.ToString(n * 2);
                label3.Text = "Матрица (" + s + ", " + s + ")";
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < 2 * n; i++)
                    dataGridView1.Columns.Add("Элемент массива", "Элемент массива");
                dataGridView1.Rows.Add(2 * n + 1);
                for (int i = 0; i < 2 * n; ++i)
                    for (int j = 0; j < 2 * n; ++j)
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j];
            }
            catch
            {
                MessageBox.Show("Повторно введите n.\nПомните, что n имеет числовой формат!!\nТакже n больше нуля!", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (n > 0)
                MessageBox.Show("Выполнено успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
