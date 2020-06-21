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
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
        }
        public void P()
        {
            MessageBox.Show("Правильно!!", "Ответ:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }
        public void N()
        {
            MessageBox.Show("Неправильно!!", "Ответ:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(listBox1.SelectedItem))
            {
                

                case "If Then Else":
                    {
                        if (listBox2.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox2.SelectedItem) == "Условный оператор")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "Begin":
                    {
                        if (listBox2.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox2.SelectedItem) == "Начало")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "End":
                    {
                        if (listBox2.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox2.SelectedItem) == "Конец")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "While do":
                    {
                        if (listBox2.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox2.SelectedItem) == "Цикл с предусловием")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "Repeat Until":
                    {
                        if (listBox2.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox2.SelectedItem) == "Цикл с постусловием")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(listBox2.SelectedItem))
            {
                case "Цикл с постусловием":
                    {
                        if (listBox1.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox1.SelectedItem) == "Repeat Until")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "Начало":
                    {
                        if (listBox1.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox1.SelectedItem) == "Begin")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "Условный оператор":
                    {
                        if (listBox1.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox1.SelectedItem) == "If Then Else")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "Конец":
                    {
                        if (listBox1.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox1.SelectedItem) == "End")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
                case "Цикл с предусловием":
                    {
                        if (listBox1.SelectedIndex >= 0)
                        {
                            if (Convert.ToString(listBox1.SelectedItem) == "While do")
                            {
                                P();
                            }
                            else
                            {
                                N();
                            }
                        }
                    }
                    break;
            }
        }
    }
}
