using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Vodyannikov_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Элемент строки", "Элемент строки");
            try
            {
                string st = textBox1.Text;
                dataGridView1.Rows.Add(st.Length);
                List<char> uniq = new List<char>(); // формируем список в котором будут храниться встреченные символы
                int count = 0;
                int l = 0;
                foreach (var c in st) // просмотрим каждый символ в строке
                    if (uniq.IndexOf(c) == -1) // если такого еще нет в списке встреченных
                    {
                        uniq.Add(c); // добавим его
                        count++; // подсчитаем его
                        dataGridView1.Rows[l].Cells[0].Value = c; //выводим дгв
                        l++;
                    }
                MessageBox.Show("Различных символов = " + Convert.ToString(count)); //выводим кол-во уникальных
            }
            catch
            {
                MessageBox.Show("Неверное значение строки! Попробуйте снова.");
            }

        }
    }
}
