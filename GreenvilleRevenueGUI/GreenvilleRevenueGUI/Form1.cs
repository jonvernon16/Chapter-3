using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_revenue_Click(object sender, EventArgs e)
        {
            int lastYear;
            int thisYear;
            int total;

            lastYear = Convert.ToInt32(txt_entry1.Text);
            thisYear = Convert.ToInt32(txt_entry2.Text);

            total = thisYear * 25;

            txt_total.Text = "The predicted revenue is $" + total;
            if (lastYear >= thisYear)
            {
                txt_bool.Text = "No";
            }
            else
            {
                txt_bool.Text = "Yes";
            }

        }
    }
}
