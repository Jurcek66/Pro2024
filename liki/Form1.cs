using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void izrKvadrat_Click(object sender, EventArgs e)
        {
            int a = int.Parse(stranica.Text);
            int obseg1 = 4 * a;
            int ploščina1 = a * a;
            obseg.Text = obseg1.ToString();
            ploščina.Text = ploščina1.ToString();


        }

        private void ploščina_TextChanged(object sender, EventArgs e)
        {

        }

        private void izrKrog_Click(object sender, EventArgs e)
        {
            double a = double.Parse(polmer.Text);
            double obseg1 = 2 * Math.PI * a;
            double ploščina1 = Math.PI * a * a;
            obsegkrog.Text = obseg1.ToString();
            ploščinakrog.Text = ploščina1.ToString();
        }
    }
}
