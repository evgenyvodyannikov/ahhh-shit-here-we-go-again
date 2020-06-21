using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_14
{
    public partial class Form1 : Form
    {
        public Point PreviousPoint, point;
        public Bitmap bmp;
        public Bitmap bmp1;
        private Pen blackPen;
        private Graphics g;
        public Image image;
        public Color clr;
        public int tolsh;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clr = Color.Black;
            tolsh = 4;
            blackPen = new Pen(clr, tolsh);
            toolStripMenuItem5.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(dialog.FileName);
                bmp1 = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp1;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                g = Graphics.FromImage(bmp1);
            }
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point.X = e.X;
                point.Y = e.Y;
                try { g.DrawLine(blackPen, PreviousPoint, point); } catch { }
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bmp1.Width; i++)
                    for (int j = 0; j < bmp1.Height; j++)
                    {
                        int R = bmp1.GetPixel(i, j).R;
                        int G = bmp1.GetPixel(i, j).G;
                        int B = bmp1.GetPixel(i, j).B;
                        int Gray = (R = G + B) / 3;
                        Color p = Color.FromArgb(255, Gray, Gray, Gray);
                        bmp1.SetPixel(i, j, p);

                    }
                Refresh();
            }
            catch
            { MessageBox.Show("Для выполнения этого действия сначала нужно открыть картинку", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                цветToolStripMenuItem.ForeColor = colorDialog1.Color;
                clr = colorDialog1.Color;
                blackPen = new Pen(clr, tolsh);
            }
        }

        public void LenDumat()
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string s = sender.ToString();
            if (s == "1")
            {
                LenDumat();
                toolStripMenuItem2.Checked = true;
                tolsh = 1;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "2")
            {
                LenDumat();
                toolStripMenuItem3.Checked = true;
                tolsh = 2;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "3")
            {
                LenDumat();
                toolStripMenuItem4.Checked = true;
                tolsh = 3;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "4")
            {
                LenDumat();
                toolStripMenuItem5.Checked = true;
                tolsh = 4;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "5")
            {
                LenDumat();
                toolStripMenuItem6.Checked = true;
                tolsh = 5;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "6")
            {
                LenDumat();
                toolStripMenuItem7.Checked = true;
                tolsh = 6;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "7")
            {
                LenDumat();
                toolStripMenuItem8.Checked = true;
                tolsh = 7;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "8")
            {
                LenDumat();
                toolStripMenuItem9.Checked = true;
                tolsh = 8;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "9")
            {
                LenDumat();
                toolStripMenuItem10.Checked = true;
                tolsh = 9;
                blackPen = new Pen(clr, tolsh);
            }
            if (s == "10")
            {
                LenDumat();
                toolStripMenuItem11.Checked = true;
                tolsh = 10;
                blackPen = new Pen(clr, tolsh);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(bmp1, image.Width, image.Height);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как ...";
                savedialog.OverwritePrompt = true;
                savedialog.Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = savedialog.FileName;
                    string strFileExtn = fileName.Remove(0, fileName.Length - 3);
                    switch (strFileExtn)
                    {
                        case "bmp":
                            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case "jpg":
                            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case "gif":
                            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case "tif":
                            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                            break;
                        case "png":
                            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            { MessageBox.Show("Для выполнения этого действия сначала нужно открыть картинку", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
