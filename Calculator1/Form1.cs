using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, r;
        string op;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum.Text))
            {
                n2 = Convert.ToDouble(txtNum.Text);

                switch (op)
                {
                    case "+":
                        r = n1 + n2;
                        break;

                }
                txtNum.Text = r.ToString();
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(txtNum.Text.Length>0)
            {
                txtNum.Text=txtNum.Text.Substring(0, txtNum.Text.Length-1);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            n2 = 0;
            txtNum.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            txtNum.Text = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            n1=Convert.ToDouble(txtNum.Text);
            r = -n1;
            txtNum.Text = r.ToString();
        }

        private void btnSquareRoot(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtNum.Text);
            r = Math.Sqrt(n1);
            txtNum.Text = r.ToString();

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txtNum.Text);
            r = n1 * n2 / 100;
            txtNum.Text = r.ToString();

        }

        private void btnOneByX(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtNum.Text);
            r = 1 / n1;
            txtNum.Text = r.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(txtNum.Text.IndexOf(".")==-1)
            {
                txtNum.Text += "."; 
            }

        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtNum.Text += btn.Text;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op= btn.Text;
            n1 = Convert.ToDouble(txtNum.Text);
            txtNum.Text = "";
        }
    }
}
