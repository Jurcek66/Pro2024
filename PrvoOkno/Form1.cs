using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvoOkno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //txtp.Focus();
        }

        private void seštej(object sender, EventArgs e)
        {
            //dobi vsebino text boxa
            double prvo = int.Parse(txtp.Text);
            int drugo = int.Parse(txtd.Text);
            double r = 0;
            if (radplus.Checked)
                r = prvo + drugo;
            if (radminus.Checked)
                r = prvo - drugo;
            if (radkrat.Checked) 
                r = prvo * drugo;
            if (raddeljeno.Checked)
                r =Math.Round( (double)prvo / drugo,4);
           
            txtr.Text = r + "";
            if (chkneg.Checked == true && r < 0)
                txtr.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtp.Text = "";
            txtd.Clear();
            txtr.Clear();
            txtr.BackColor = Color.White;
            txtp.Focus();

        }
    }
}
