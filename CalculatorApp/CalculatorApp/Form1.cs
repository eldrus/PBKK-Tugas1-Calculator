using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string opt;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            opt = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            opt = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            opt = "*";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            opt = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonEql_Click(object sender, EventArgs e)
        {
            
            num2 = int.Parse(txtTotal.Text);

            if (opt.Equals("+"))
                result = num1 + num2;

            if(opt.Equals("-"))
                result = num1 - num2;

            if (opt.Equals("*"))
                result = num1 * num2;

            if (opt.Equals ("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }
    }
}
