using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_eggs_Click(object sender, EventArgs e)
        {
            int eggs1;
            int eggs2;
            int eggs3;
            int eggs4;
            int eggs5;
            int sumOfEggs;
            int dozen;
            int remainder;

            eggs1 = Convert.ToInt32(txt_entry1.Text);
            eggs2 = Convert.ToInt32(txt_entry2.Text);
            eggs3 = Convert.ToInt32(txt_entry3.Text);
            eggs4 = Convert.ToInt32(txt_entry4.Text);
            eggs5 = Convert.ToInt32(txt_entry5.Text);

            sumOfEggs = eggs1 + eggs2 + eggs3 + eggs4 + eggs5;
            dozen = sumOfEggs / 12;
            remainder = sumOfEggs % 12;

            txt_result.Text = "The total amount of eggs is\n " + sumOfEggs + " The amount in dozens is"
                + dozen + " with " + remainder + " remaining.";
        }
    }
}
