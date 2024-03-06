using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace _4vvrsto
{
    public partial class Form1 : Form
    {

        int S_CELICA = 100; //širina enega kvadratka
        int[,] STANJE ={
        {0,0,0,0,0,0,0},
        {0,0,0,1,0,0,0},
        {0,0,1,2,0,0,0},
        {0,1,2,1,2,0,0},
        {1,1,2,2,1,2,0}
        };
        int ST_VRSTIC = 5;
        int ST_STOLPCEV = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ST_VRSTIC = STANJE.GetLength(0);
            ST_STOLPCEV = STANJE.GetLength(1);
            narišiVodoravne(g);
            narišiNavpične(g);
            narišiKrožce(g);
        }

        private void narišiKrožce(Graphics g)
        {
            SolidBrush barva = new SolidBrush(Color.Red);
            for(int k=0;k<ST_VRSTIC;k++)
            {
                for(int j=0;j<ST_STOLPCEV;j++)
                {
                    if (STANJE[k,j]!=0)
                    {
                        if (STANJE[k,j]==1)
                        {
                            barva = new SolidBrush(Color.Green);
                        }
                        else
                        {
                            barva = new SolidBrush(Color.Red);
                        }
                        g.FillEllipse(barva, j*100+5, k*100+5, 90, 90);
                    }
                }
            }
        }

        private void narišiNavpične(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            for (int i=0;i<=ST_STOLPCEV;i++)
            {
                g.DrawLine(p,i*100,0, i*100, ST_VRSTIC * 100);
            }
        }

        private void narišiVodoravne(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            for (int i = 0; i <= ST_VRSTIC; i++)
            {
                g.DrawLine(p, 0,i * 100, ST_STOLPCEV * 100,i*100) ;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("kliknil si na " + e.X + ", " + e.Y);
            int vrstica = e.Y / 100;
            int stolpec = e.X / 100;
            STANJE[vrstica, stolpec] = 1;
            pictureBox1.Invalidate();
        }
    }
}
