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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your value !!!");
            else
                this.errorProvider1.Clear();
        }
        static Boolean KtraSNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text);
            string s = textBox1.Text + "\t" + " la so nguyen to";
            for (int i = 2; i < t; i++)
            {
                if (KtraSNT(t))
                    label3.Text = s;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text);
            string s = "Cac so nguyen to trong khoang tu 2." + textBox1.Text + " la:";
            label4.Text = s;
            string x = " ";
            for (int i = 1; i <= t; i++)
                if(KtraSNT(i))
            {
               x = x +i.ToString() + " ";
                    label5.Text = x;
            }

        }
    }
}

