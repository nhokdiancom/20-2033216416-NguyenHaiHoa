using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoNguyenTo
{
    public partial class PTBac2 : Form
    {
        public PTBac2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must enter your value");
            }
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must enter your value");
            }
            else
                this.errorProvider1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must enter your value");
            }
            else
                this.errorProvider1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                label5.Text = "PT vo nghiem";
            }
            else if (delta == 0)
            {
                label5.Text = "PT co 1 nghiem";
            }
            else
                label5.Text = "PT co 2 nghiem phan biet";
        }
    }
}
