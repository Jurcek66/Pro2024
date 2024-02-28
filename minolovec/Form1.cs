using MinolovecGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minolovec
{
    public partial class Form1 : Form
    {
        Button[,] x;
        int n = 10;
        LogikaIgre a = new LogikaIgre(10);

        public Form1()
        {
            InitializeComponent();
            x = new Button[n + 2, n + 2];
            NastaviGumbe();
        }

        private void Prikaži(object sender, EventArgs e)
        {
            //za vs egumbe se kliče ista metoda
            Button b = sender as Button;
            //v b se nahaja gumb ki sem ga kliknila
            if (b.Text == "*")
                MessageBox.Show("Konec igre!");
            else
                b.ForeColor = Color.Black;
        }
        private void NastaviGumbe()
        {
            for (int k = 1; k <= n; k++)
            {
                for (int j = 1; j <= n; j++)
                {
                    x[k, j] = new Button();
                    x[k, j].Size = new Size(30, 30);
                    x[k, j].Location = new Point(k * 30, j * 30);
                    if (a.mine[k, j] == true)
                        x[k, j].Text = "*";
                    else
                        x[k, j].Text = a.rešitev[k, j].ToString();
                    x[k, j].BackColor = Color.White;
                    x[k, j].ForeColor = Color.White;
                    x[k, j].Click += new EventHandler(Prikaži);
                    this.Controls.Add(x[k, j]);
                }
            }
        }
        private void BrišiIzForme()
        {
            for (int k = 1; k <= n; k++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Controls.Remove(x[k, j]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "težko")
            {
                BrišiIzForme();
                button1.Text = "lahko";
                n = 20;
                x = new Button[n + 2, n + 2];
                a= new LogikaIgre(20);
                NastaviGumbe();

            }
            else
            {
                BrišiIzForme();
                button1.Text = "težko";
                n = 10;
                x = new Button[n + 2, n + 2];
                a= new LogikaIgre(10);
                NastaviGumbe();
            }
                
        }
    }
}
