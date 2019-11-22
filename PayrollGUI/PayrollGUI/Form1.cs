using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
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

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string name;
            int ssn;
            double hourPay;
            double hoursWorked;
            double grossPay;
            double fedTax;
            double stateTax;
            double netPay;

            name = txt_entry1.Text;
            ssn = Convert.ToInt32(txt_entry2.Text);
            hourPay = Convert.ToDouble(txt_entry3.Text);
            hoursWorked = Convert.ToDouble(txt_entry4.Text);

            grossPay = hourPay * hoursWorked;
            fedTax = 0.15 * grossPay;
            stateTax = 0.05 * grossPay;
            netPay =  grossPay - (fedTax + stateTax);

            txt_gross.Text = "Gross pay is $" + grossPay;
            txt_fedTax.Text = "Federal tax is $" + fedTax;
            txt_stateTax.Text = "State tax is $" + stateTax;
            txt_netPay.Text = "Net pay is $" + netPay;
        }
    }
}
