using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            double test1;
            double test2;
            double test3;
            double test4;
            double test5;
            double testAverage;

            test1 = Convert.ToDouble(txt_entry1.Text);
            test2 = Convert.ToDouble(txt_entry2.Text);
            test3 = Convert.ToDouble(txt_entry3.Text);
            test4 = Convert.ToDouble(txt_entry4.Text);
            test5 = Convert.ToDouble(txt_entry5.Text);

            testAverage = (test1 + test2 + test3 + test4 + test5) / 5;

            txt_result.Text = "The average is " + testAverage;

        }
    }
}
