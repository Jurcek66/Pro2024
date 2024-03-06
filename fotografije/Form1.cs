using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotografije
{
    public partial class Form1 : Form
    {
        Bitmap original = new Bitmap(640, 400);
        public Form1()
        {
            InitializeComponent();
        }
        private void odpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOdpri.Filter = "SLIKE(*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|Vse|*.*";
            DialogResult a = dlgOdpri.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string imedatoteke = dlgOdpri.FileName;
            original = new Bitmap(imedatoteke);
            pictureBox1.Image = original;
            posodobiSliko();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void nastaviDrsnike()
        {
            if(original.Width<pictureBox1.Width)
            {
                hScrollBar1.Visible = false;
            }
            else
            {
                hScrollBar1.Visible = true;
                hScrollBar1.Maximum = original.Width - pictureBox1.Width;
            }

            if (original.Height < pictureBox1.Height)
            {
                vScrollBar1.Visible = false;
            }
            else
            {
                vScrollBar1.Visible = true;
                vScrollBar1.Maximum = original.Height - pictureBox1.Height;
            }

        }
        private void posodobiSliko()
        {
            nastaviDrsnike();
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle r1 = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            Rectangle r2 = new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox1.Width, pictureBox1.Height);
            g.DrawImage(original, r1, r2, GraphicsUnit.Pixel);
            pictureBox1.Update();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            posodobiSliko();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            posodobiSliko();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            posodobiSliko();
        }

        private void navpičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            for (int x = 0; x < original.Width / 2;x++)
            {
                for(int y=0;y<original.Height;y++)
                {
                    pixel = original.GetPixel(x, y);
                    original.SetPixel(original.Width - x - 1,y,pixel);
                }
                posodobiSliko();
            }
        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int x=0;x<original.Width;x++)
            {
                for(int y=0;y<original.Height;y++)
                {
                    Color barva = original.GetPixel(x, y);
                    int rdeča = 255 - barva.R;
                    int zelena = 255 - barva.G;
                    int modra = 255 - barva.G;
                    barva = Color.FromArgb(rdeča, zelena, modra);
                    original.SetPixel(x, y, barva);
                }
                posodobiSliko();
            }
        }

        private void za90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate90FlipNone);
            posodobiSliko();
        }

        private void za180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate180FlipNone);
            posodobiSliko();
        }

        private void za270wToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate270FlipNone);
            posodobiSliko();
        }

        private void vodoravnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height/2; y++)
                {
                    pixel = original.GetPixel(x, y);
                    original.SetPixel(x,original.Height - y - 1, pixel);
                }
                posodobiSliko();
            }
        }

        private void posvetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float svetlost = 1.1f; 
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color barva = original.GetPixel(x, y);
                    int rdeča = (int)(barva.R * svetlost);
                    if (rdeča > 255)
                        rdeča = 255;
                    int zelena = (int)(barva.G * svetlost);
                    if (zelena > 255)
                        zelena = 255;
                    int modra = (int)(barva.B * svetlost);
                    if (modra > 255)
                        modra = 255;
                    barva = Color.FromArgb(rdeča, zelena, modra);
                    original.SetPixel(x, y, barva);
                }
                posodobiSliko();
            }
        }

        private void potemniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float svetlost = 0.8f;
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color barva = original.GetPixel(x, y);
                    int rdeča = (int)(barva.R * svetlost);
                    if (rdeča < 0)
                        rdeča = 0;
                    int zelena = (int)(barva.G * svetlost);
                    if (zelena < 0)
                        zelena = 0;
                    int modra = (int)(barva.B * svetlost);
                    if (modra < 0)
                        modra = 0;
                    barva = Color.FromArgb(rdeča, zelena, modra);
                    original.SetPixel(x, y, barva);
                }
                posodobiSliko();
            }
        }
    }
}
