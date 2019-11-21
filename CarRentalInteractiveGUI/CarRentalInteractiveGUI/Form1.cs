using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carRental_Click(object sender, EventArgs e)
        {
            double miles;
            double days;
            double milesFee = 0.25;
            double daysFee = 20.00;
            double total;

            miles = Convert.ToDouble(txt_entry1.Text);
            days = Convert.ToDouble(txt_entry2.Text);

            total = (miles * milesFee) + (days * daysFee);

            txt_result.Text = "The bill is $" + total;
        }
    }
}
