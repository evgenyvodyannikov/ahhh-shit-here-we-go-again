using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int ConvertDateTimeToInt32(DateTime dt)
        {
            return (int)(dt - new DateTime(2020, 1, 1)).TotalDays;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.database2DataSet.Students);
            dataGridView1.Width = 450;
            dataGridView1.Height = 250;
            int k = dataGridView1.Rows.Count;
            for (int i = 0; i < k; i++)
            {
                if (dataGridView1.Rows[i].Cells[11].Value != null)
                {
                    DateTime dt = Convert.ToDateTime(dataGridView1.Rows[i].Cells[11].Value);
                    dataGridView1.Rows[i].Cells[12].Value = Math.Abs(ConvertDateTimeToInt32(dt) / 365);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавить столбец с именем column-1, заголовок столбца - "Header column - 1"
            dataGridView1.Columns.Add("column-1", "Новый стольбец - 1");
            label1.Text = "Столбец добавлен";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int index; 
            int n; 
            n = dataGridView1.Columns.Count;
            index = n - 1;

            // удаление
            if ((n > 0) && (index >= 0) && (index < n))
            {
                dataGridView1.Columns.RemoveAt(index);
                label1.Text = "Столбец удален";
            }
            else
            {
                label1.Text = "Столбец не удален";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count <= 0)
            {
                label1.Text = "Строки не добавлены";
                return;
            }
            try
            {
                dataGridView1.Rows.Add("Ivanov I.I.", 25, "New York");
                dataGridView1.Rows.Add("Petrenko P.P.", 38, "Moscow");
                label1.Text = "Строки добавлены";
            }
            catch
            {
                MessageBox.Show("Строки нельзя программным способом добавить в коллекцию строк DataGridView, если элемент управления привязан к данным.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Удалить строку
            int nr, nc;

            nc = dataGridView1.Columns.Count; // количество столбцов
            nr = dataGridView1.RowCount;

            if ((nc > 0) && (nr > 1))
            {
                dataGridView1.Rows.RemoveAt(0); // удалить первую строку
                label1.Text = "Строка удалена";
            }
            else
            {
                label1.Text = "Строка не удалена";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // задать текст в заголовке
            int nc = dataGridView1.ColumnCount;
            for (int n = 0; n < nc; n++)
            {
                dataGridView1.Columns[n].HeaderText = "Заголовок " + n.ToString();
            }
            label1.Text = "Текст задан";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nc;
            nc = dataGridView1.ColumnCount;
            for (int n = 0; n < nc; n++)
            {
              
                dataGridView1.Columns[n].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
            }
            label1.Text = "Выравнивание выполнено";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // задать шрифт в заголовке
            int nc;
            nc = dataGridView1.ColumnCount;

            // создать шрифт "Arial", размер 12, начертание - "курсив"
            Font F = new Font("Arial", 12, FontStyle.Italic);

            if (nc > 0)
            {
                // установить шрифт заголовка
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = F;

                label1.Text = "Шрифт задан";
            }
            else
            {
                label1.Text = "Шрифт не задан";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int nc;
            nc = dataGridView1.RowCount;
            for (int n = 0; n < nc; n++)
            {
                Font F = new Font("Arial", 14);


                dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.MediumVioletRed;
            }
                label1.Text = "Цвет заголовка изменен";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // задать размер dataGridView1
            dataGridView1.Width = 860;
            dataGridView1.Height = 250;
            label1.Text = "Размер установлен";

        }
    }
}
