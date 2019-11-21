using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
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

        private void btn_raise_Click(object sender, EventArgs e)
        {
            const double RAISE = 0.04;
            double salary;
            double projSalary;

            salary = Convert.ToDouble(txt_entry1.Text);
            projSalary = Convert.ToDouble(txt_entry1.Text);

            projSalary = (RAISE * salary) + salary;

            txt_result.Text = "Your salary is " + projSalary;


        }
    }
}
