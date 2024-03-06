using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        Color ozadje = Color.Wheat;
        Color ospredje = Color.FromArgb(100, 0, 0, 255);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(ozadje);
            g.FillRectangle(br, 45, 20, 150, 120);
            Brush br1 = new SolidBrush(ospredje);
            g.FillRectangle(br1, 65, 35, 170, 130);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void nstozd_Click(object sender, EventArgs e)
        {
            string bgc = barva.Text;
            ozadje = Color.FromName(bgc);
            Invalidate();

        }

        private void nstospr_Click(object sender, EventArgs e)
        {
            int alfa1 = int.Parse(alfa.Text);
            int red1 = int.Parse(red.Text);
            int green1 = int.Parse(green.Text);
            int blue1 = int.Parse(blue.Text);
            ospredje = Color.FromArgb(alfa1, red1, green1, blue1);
            Invalidate();
        }
    }
}
