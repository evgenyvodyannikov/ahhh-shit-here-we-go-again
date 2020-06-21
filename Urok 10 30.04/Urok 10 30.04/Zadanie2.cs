using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_10_30._04
{
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
        }
        int sum = 0;

        private void checkBox3_Click(object sender, EventArgs e)
        {

            CheckBox ch = (CheckBox)sender;
            if (ch.Checked == true)
            {

                switch (ch.Name)
                {
                    case "checkBox3":
                        {
                            sum += 100;
                        }
                        break;
                    case "checkBox4":
                        {
                            sum += 120;
                        }
                        break;
                    case "checkBox2":
                        {
                            sum += 150;
                        }
                        break;
                    case "checkBox1":
                        {
                            sum += 150;
                        }
                        break;
                    case "checkBox5":
                        {
                            sum += 60;
                        }
                        break;
                    case "checkBox6":
                        {
                            sum += 120;
                        }
                        break;
                    case "checkBox7":
                        {
                            sum += 35;
                        }
                        break;
                    case "checkBox8":
                        {
                            sum += 30;
                        }
                        break;
                    case "checkBox9":
                        {
                            sum += 5;
                        }
                        break;
                }
            }
            else
            {
                switch (ch.Name)
                {
                    case "checkBox3":
                        {
                            sum -= 100;
                        }
                        break;
                    case "checkBox4":
                        {
                            sum -= 120;
                        }
                        break;
                    case "checkBox2":
                        {
                            sum -= 150;
                        }
                        break;
                    case "checkBox1":
                        {
                            sum -= 150;
                        }
                        break;
                    case "checkBox5":
                        {
                            sum -= 60;
                        }
                        break;
                    case "checkBox6":
                        {
                            sum -= 120;
                        }
                        break;
                    case "checkBox7":
                        {
                            sum -= 35;
                        }
                        break;
                    case "checkBox8":
                        {
                            sum -= 30;
                        }
                        break;
                    case "checkBox9":
                        {
                            sum -= 5;
                        }
                        break;
                }
            }
            textBox1.Text = sum.ToString();
        }
    }
}
