using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodyannikov_Srtings_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool Foo(string a, string b)
        {
            var baseString = a.ToLower().GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return b.ToLower().GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count())
                .All(x => baseString.ContainsKey(x.Key) && baseString[x.Key] >= x.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    var A = Convert.ToString(textBox1.Text);
                    var B = Convert.ToString(textBox2.Text);
                    if (Foo(A, B))
                    {
                        MessageBox.Show("Верно!! Из строки " + A + "можно составить " + B);
                    }
                    else
                    {
                        MessageBox.Show("Неверно!! Из строки " + A + " нельзя составить " + B);
                    }
                }
                else
                {
                    MessageBox.Show("Введите значения строк!!!");
                }
            }
           catch
            {
                MessageBox.Show("Неверно введены строки!! Попробуйте еще раз!");
            }
            

        }
    }
}
