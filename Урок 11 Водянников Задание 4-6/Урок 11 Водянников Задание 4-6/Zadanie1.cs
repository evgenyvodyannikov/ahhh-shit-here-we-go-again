using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_11_Водянников_Задание_4_6
{
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastFormPos;
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;
        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;
        private void Zadanie1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Zadanie1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastFormPos = this.Location;
        }

        private void Zadanie1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = Point.Add(lastFormPos, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void Zadanie1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            x1 = lastFormPos.X;
            y1 = lastFormPos.Y;
            x2 = this.Location.X;
            y2 = this.Location.Y;
            if (x1 > x2)
            {
                label2.Text = "По оси x: Влево";
                left++;
                label6.Text = "Влево: " + left;
            }
            else
            {
                label2.Text = "По оси x: Вправо";
                right++;
                label7.Text = "Вправо: " + right;
            }
            if (y1 > y2)
            {
                label1.Text = "По оси y: Вверх";
                up++;
                label8.Text = "Вверх: " + up;
            }
            else
            {
                label1.Text = "По оси y: Вниз";
                down++;
                label9.Text = "Вниз: " + down;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
