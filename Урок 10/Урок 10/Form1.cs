using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Урок_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.GetEncoding("UTF-8"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);

             
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text += listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выделите строку", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("tag.txt"))
                {
                    sw.WriteLine(listBox1.Items.Count.ToString());
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i]);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                MessageBox.Show("Файл сохранен под именем tag.txt", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                using (StreamReader reader = new StreamReader("tag.txt"))
                {
                    listBox1.Items.Clear();
                    string z = reader.ReadLine();
                    for (int i = 0; i < Convert.ToDouble(z); i++)
                    {
                        listBox1.Items.Add(reader.ReadLine());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Невозможно найти файл tags.txt. Проверьте наличие файла и пропробуйте снова", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Загрузка завершена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
