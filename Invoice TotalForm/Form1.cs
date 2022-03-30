using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_TotalForm
{
    public partial class Form1 : Form
    {
        private const double DiscountPercent = 0.25;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDiscountPercent.Text = DiscountPercent.ToString("P1");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double subTotal = double.Parse(txtSubtotal.Text);
            double discountAmount = subTotal * DiscountPercent;
            double total = subTotal - discountAmount;

            txtDiscountAmount.Text = discountAmount.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
